using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StopAndGo;
using System.IO;
using System.Collections;
using System.Threading;

namespace StopAndGoWithGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private ShiftRegister TryParseShiftRegister(TextBox stateTB, TextBox maskTB)
        {
            uint uintState, uintMask;
            byte bitCount;

            if(stateTB.Text.Length != maskTB.Text.Length)
            {
                MessageBox.Show("Длина состояния должна быть равна длине маски.", stateTB.Name,
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (stateTB.Text.Length > 32)
            {
                MessageBox.Show("Длина состояния должна быть не больше 32 бит.", stateTB.Name,
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            bitCount = Convert.ToByte(stateTB.Text.Length);         

            try
            {
                uintState = Convert.ToUInt32(stateTB.Text, 2);
                uintMask = Convert.ToUInt32(maskTB.Text, 2);
            }
            catch(FormatException)
            {
                MessageBox.Show("Для состояния регистра и маски допустимы только символы '0' и '1'.", stateTB.Name,
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new ShiftRegister(uintState, bitCount, uintMask);
        }

        
        private StopAndGoGenerator TryParseInput()
        {
            ShiftRegister sr1, sr2, sr3;
            string binFilePath, bitmapFilePath;
            uint byteCount;

            sr1 = TryParseShiftRegister(state1TB, maskOrIndArr1TB);
            if (sr1 == null)
                return null;
            sr2 = TryParseShiftRegister(state2TB, maskOrIndArr2TB);
            if (sr2 == null)
                return null;
            sr3 = TryParseShiftRegister(state3TB, maskOrIndArr3TB);
            if (sr3 == null)
                return null;

            binFilePath = binFilePathTB.Text;
            bitmapFilePath = bitmapCheckBox.Checked ? bitmapFilePathTB.Text : null;

            try
            {
                byteCount = Convert.ToUInt32(byteFileSizeTB.Text);
                if (byteCount < 10)
                    throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Выходной файл не может быть меньше 10 байт.", byteFileSizeTB.Name,
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new StopAndGoGenerator(sr1, sr2, sr3);
        }

        private void ShowStateHelp(TextBox tb)
        {
            tb.Text = "состояние (бинарное)";
        }

        private void ShowXorHelp(TextBox tb)
        {
            tb.Text = "маска (бинарная)";
        }

        private void registersType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowStateHelp(state1TB);
            ShowStateHelp(state2TB);
            ShowStateHelp(state3TB);
            ShowXorHelp(maskOrIndArr1TB);
            ShowXorHelp(maskOrIndArr2TB);
            ShowXorHelp(maskOrIndArr3TB);
        }

        private void setDefaultButton_Click(object sender, EventArgs e)
        {           
            maskOrIndArr1TB.Text = "10000000000000100"; // x^17 + x^3 + 1   
            state1TB.Text =        "10000011100100100";

            maskOrIndArr2TB.Text = "10000000000000000010000"; // x^23 + x^5 + 1  
            state2TB.Text =        "10000111000110010010000"; 

            maskOrIndArr3TB.Text = "1000000000000000000000000100000"; // x^31 + x^6 + 1   
            state3TB.Text =        "1100111010101001110101011110010";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StopAndGoGenerator sag = TryParseInput();
            if (sag == null)
                return;
            startButton.Enabled = false;
            var color = startButton.BackColor;

            startButton.BackColor = BackColor;

            GenerateBytes(
                sag,
                Convert.ToUInt32(byteFileSizeTB.Text),
                binFilePathTB.Text,
                bitmapFilePathTB.Text);

            startButton.Enabled = true;
            startButton.BackColor = color;
        }

        public void GenerateBytes(
            StopAndGoGenerator sag,
            uint count,
            string binFilePath,
            string bitmapFilePath = null)
        {
            byte[] bytearr = new byte[count];
            progressMsg.Text = "Генерация бинарного файла...";
            for (uint i = 0; i < count; i++)
            {
                bytearr[i] = sag.StepByte();
                if (i % 10000 == 0)
                    progressBar1.Value = Convert.ToInt32(Math.Round(((double)i / (double)count) * 100, 0));
                Application.DoEvents();
            }
            File.WriteAllBytes(binFilePath, bytearr);
            progressBar1.Value = 100;
            progressMsg.Text = "Готово.";

            if (bitmapFilePath != null && bitmapCheckBox.Checked)
            {
                progressMsg.Text = "Создание рисунка...";
                progressBar1.Value = 0;
                try
                {
                    BitArray bitArray = new BitArray(bytearr);
                    int bitRectangleSide = Convert.ToInt32(Math.Abs(Math.Sqrt(Convert.ToDouble(bitArray.Length))));
                    Bitmap bitmap = new Bitmap(bitRectangleSide, bitRectangleSide);

                    int currBitInd = 0;
                    for (int i = 0; i < bitmap.Width; i++)
                    {
                        for (int j = 0; j < bitmap.Height; j++)
                        {
                            Color c = bitArray[currBitInd] ? Color.Black : Color.White;
                            bitmap.SetPixel(i, j, c);                            
                            if (currBitInd % 10000 == 0)
                                progressBar1.Value = Convert.ToInt32(Math.Round(((double)currBitInd / (double)bitArray.Length) * 100, 0));
                            currBitInd++;
                            if (currBitInd == bitArray.Length)
                                break;
                            Application.DoEvents();
                        }
                    }

                    bitmap.Save(bitmapFilePath);
                }
                catch (Exception ex)
                {
                    StreamWriter log = File.CreateText(bitmapFilePath + ".log");
                    log.Write("Не удалось создать рисунок:\r\n" + ex.ToString());
                    log.Close();
                    progressMsg.Text = String.Format("Ошибка при создании рисунка, подробности: {0}.log.", bitmapFilePath);
                    return;
                }
                progressMsg.Text = "Готово.";
                progressBar1.Value = 100;
            }
        }
    }
}
