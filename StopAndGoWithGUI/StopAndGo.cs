using System;

namespace StopAndGo
{    
    public class StopAndGoGenerator
    {
        #region Properties

        private ShiftRegister Sr1 { get; set; } // ГПСП1
        private ShiftRegister Sr2 { get; set; } // ГПСП2
        private ShiftRegister Sr3 { get; set; } // ГПСП3

        #endregion

        #region Constructors

        // Конструктор класса.    
        public StopAndGoGenerator(
          ShiftRegister sr1,
          ShiftRegister sr2,
          ShiftRegister sr3)
        {
            Sr1 = sr1; // ГПСП1
            Sr2 = sr2; // ГПСП2
            Sr3 = sr3; // ГПСП3
        }

        #endregion

        #region Methods
      
        // Метод генерирует бит ПСП.
        public byte Step()
        {
            // получаем следующий бит от управляющего регистра (сдвиг ГПСП1)
            byte sr1Out = Sr1.Step();
            // бит от ГПСП2
            byte sr2Out;
            // бит от ГПСП3
            byte sr3Out;

            // если управляющий бит равен 1
            if(sr1Out == 1)
            {
                // следующий бит от ГПСП2 (сдвиг)
                sr2Out = Sr2.Step();
                // текущий бит от ГПСП3
                sr3Out = Sr3.GetBit(0);
            }
            // если управляющий бит равен 0
            else
            {
                // текущий бит от ГПСП2
                sr2Out = Sr2.GetBit(0);                
                // следующий бит от ГПСП3 (сдвиг)
                sr3Out = Sr3.Step();
            }
            // возврат результата операции бит ГПСП2 XOR  бит ГПСП3
            return(Convert.ToByte(sr2Out ^ sr3Out));
        }
               
        // Метод составляет байт из 8 битовых шагов.       
        public byte StepByte()
        {
            // вызов метода, который возвращает следующий бит ПСП и сохранение значения этого бита
            byte outByte = Step(); 

            // повторить 7 раз, т.к. один бит уже получен
            for(byte i = 1; i < 8; i++)
            {
                // сдвиг влево и добавление "0" справа
                outByte <<= 1;
                // добавленный бит принимает знаение следующего бита последовательности
                outByte |= Step();
            }
            // возврат получившегося 8-ми битного значения
            return outByte;
        }

        #endregion
    }
}
