namespace StopAndGoWithGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.state1TB = new System.Windows.Forms.TextBox();
            this.maskOrIndArr1TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.state2TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.state3TB = new System.Windows.Forms.TextBox();
            this.setDefaultButton = new System.Windows.Forms.Button();
            this.maskOrIndArr3TB = new System.Windows.Forms.TextBox();
            this.maskOrIndArr2TB = new System.Windows.Forms.TextBox();
            this.bitmapCheckBox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.byteFileSizeTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.binFilePathTB = new System.Windows.Forms.TextBox();
            this.bitmapFilePathTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressMsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Настройка регистров:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Регистр 1 (управляющий):";
            // 
            // state1
            // 
            this.state1TB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.state1TB.Location = new System.Drawing.Point(16, 89);
            this.state1TB.Name = "state1";
            this.state1TB.Size = new System.Drawing.Size(370, 18);
            this.state1TB.TabIndex = 4;
            this.state1TB.Text = "состояние (бинарное)";
            // 
            // maskOrIndArr1
            // 
            this.maskOrIndArr1TB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskOrIndArr1TB.Location = new System.Drawing.Point(16, 115);
            this.maskOrIndArr1TB.Name = "maskOrIndArr1";
            this.maskOrIndArr1TB.Size = new System.Drawing.Size(370, 18);
            this.maskOrIndArr1TB.TabIndex = 5;
            this.maskOrIndArr1TB.Text = "маска (бинарная)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Регистр 2:";
            // 
            // state2
            // 
            this.state2TB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.state2TB.Location = new System.Drawing.Point(16, 161);
            this.state2TB.Name = "state2";
            this.state2TB.Size = new System.Drawing.Size(370, 18);
            this.state2TB.TabIndex = 7;
            this.state2TB.Text = "состояние (бинарное)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Регистр 3:";
            // 
            // state3
            // 
            this.state3TB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.state3TB.Location = new System.Drawing.Point(16, 237);
            this.state3TB.Name = "state3";
            this.state3TB.Size = new System.Drawing.Size(370, 18);
            this.state3TB.TabIndex = 10;
            this.state3TB.Text = "состояние (бинарное)";
            // 
            // setDefaultButton
            // 
            this.setDefaultButton.BackColor = System.Drawing.Color.LimeGreen;
            this.setDefaultButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setDefaultButton.Location = new System.Drawing.Point(194, 19);
            this.setDefaultButton.Name = "setDefaultButton";
            this.setDefaultButton.Size = new System.Drawing.Size(192, 32);
            this.setDefaultButton.TabIndex = 12;
            this.setDefaultButton.Text = "Настроить по умолчанию";
            this.setDefaultButton.UseVisualStyleBackColor = false;
            this.setDefaultButton.Click += new System.EventHandler(this.setDefaultButton_Click);
            // 
            // maskOrIndArr3
            // 
            this.maskOrIndArr3TB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskOrIndArr3TB.Location = new System.Drawing.Point(16, 263);
            this.maskOrIndArr3TB.Name = "maskOrIndArr3";
            this.maskOrIndArr3TB.Size = new System.Drawing.Size(370, 18);
            this.maskOrIndArr3TB.TabIndex = 11;
            this.maskOrIndArr3TB.Text = "маска (бинарная)";
            // 
            // maskOrIndArr2
            // 
            this.maskOrIndArr2TB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskOrIndArr2TB.Location = new System.Drawing.Point(16, 187);
            this.maskOrIndArr2TB.Name = "maskOrIndArr2";
            this.maskOrIndArr2TB.Size = new System.Drawing.Size(370, 18);
            this.maskOrIndArr2TB.TabIndex = 8;
            this.maskOrIndArr2TB.Text = "маска (бинарная)";
            // 
            // bitmapCheckBox
            // 
            this.bitmapCheckBox.AutoSize = true;
            this.bitmapCheckBox.Checked = true;
            this.bitmapCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bitmapCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bitmapCheckBox.Location = new System.Drawing.Point(495, 303);
            this.bitmapCheckBox.Name = "bitmapCheckBox";
            this.bitmapCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bitmapCheckBox.Size = new System.Drawing.Size(157, 24);
            this.bitmapCheckBox.TabIndex = 13;
            this.bitmapCheckBox.Text = "Создать рисунок";
            this.bitmapCheckBox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LimeGreen;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(495, 401);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(240, 56);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Размер выходного файла (в байтах):";
            // 
            // byteFileSize
            // 
            this.byteFileSizeTB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byteFileSizeTB.Location = new System.Drawing.Point(16, 335);
            this.byteFileSizeTB.Name = "byteFileSize";
            this.byteFileSizeTB.Size = new System.Drawing.Size(240, 18);
            this.byteFileSizeTB.TabIndex = 16;
            this.byteFileSizeTB.Text = "11534336";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Путь к выходному файлу:";
            // 
            // binFilePath
            // 
            this.binFilePathTB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binFilePathTB.Location = new System.Drawing.Point(16, 387);
            this.binFilePathTB.Name = "binFilePath";
            this.binFilePathTB.Size = new System.Drawing.Size(240, 18);
            this.binFilePathTB.TabIndex = 18;
            this.binFilePathTB.Text = "stop-and-go-bytes.bin";
            // 
            // bitmapFilePath
            // 
            this.bitmapFilePathTB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bitmapFilePathTB.Location = new System.Drawing.Point(14, 439);
            this.bitmapFilePathTB.Name = "bitmapFilePath";
            this.bitmapFilePathTB.Size = new System.Drawing.Size(240, 18);
            this.bitmapFilePathTB.TabIndex = 19;
            this.bitmapFilePathTB.Text = "stop-and-go-bitmap.png";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Путь к файлу с рисунком:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 495);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(719, 21);
            this.progressBar1.TabIndex = 21;
            // 
            // progressMsg
            // 
            this.progressMsg.AutoSize = true;
            this.progressMsg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressMsg.Location = new System.Drawing.Point(16, 519);
            this.progressMsg.Name = "progressMsg";
            this.progressMsg.Size = new System.Drawing.Size(140, 18);
            this.progressMsg.TabIndex = 22;
            this.progressMsg.Text = "Строка состояния";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 228);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(781, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressMsg);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bitmapFilePathTB);
            this.Controls.Add(this.binFilePathTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.byteFileSizeTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.bitmapCheckBox);
            this.Controls.Add(this.setDefaultButton);
            this.Controls.Add(this.maskOrIndArr3TB);
            this.Controls.Add(this.state3TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskOrIndArr2TB);
            this.Controls.Add(this.state2TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskOrIndArr1TB);
            this.Controls.Add(this.state1TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Stop and go - pseudo random generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox state1TB;
        private System.Windows.Forms.TextBox maskOrIndArr1TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox state2TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox state3TB;
        private System.Windows.Forms.Button setDefaultButton;
        private System.Windows.Forms.TextBox maskOrIndArr3TB;
        private System.Windows.Forms.TextBox maskOrIndArr2TB;
        private System.Windows.Forms.CheckBox bitmapCheckBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox byteFileSizeTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox binFilePathTB;
        private System.Windows.Forms.TextBox bitmapFilePathTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

