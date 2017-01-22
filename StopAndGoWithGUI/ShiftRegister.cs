using System;

namespace StopAndGo
{    
    
    // Реализация РСЛОС с наложением маски   
    public class ShiftRegister
    {
        #region Properties
        // состояние регистра
        public uint State { get; private set; }
        // количество ячеек (бит) - длина регистра
        public byte BitCount { get; private set; }
        // строковое представение состояния
        public string StrState
        {
            get
            {
                string binState = Convert.ToString(State, 2);
                return binState.Length < BitCount ? new String('0', BitCount - binState.Length) + binState : binState;
            }
        }
        // маска из единиц, длина которой равна длине регистра
        private uint OnesMask { get; set; }
        // маска-полином для операции XOR с состоянием регистра
        private uint PolynomMask { get; set; }

        #endregion

        #region Constructors

        // Конструктор класса.     
        public ShiftRegister(uint state, byte bitCount, uint polynomMask)
        {
            // состояние регистра
            State = state;
            // количество ячеек (бит) - длина регистра
            BitCount = bitCount;
            // маска из единиц, длина которой равна длине регистра
            OnesMask = Convert.ToUInt32(new String('1', bitCount), 2);
            // маска-полином для операции XOR с состоянием регистра
            PolynomMask = polynomMask;
        }

        #endregion

        #region Methods

        // Сдвиг регистра и получение следующего бита ПСП.    
        public byte Step()
        {
            // выходной бит - старший бит состояния
            byte outputBit = GetBit(0);
            // циклический сдвиг
            CircShift();
            // если выходной бит равен 1
            if (outputBit == 1)
            {
                // выполняется операция "состояние регистра XOR маска-полином"
                // результат операции является новым состоянием регистра
                State ^= PolynomMask;
            }
            // возврат бита ПСП
            return outputBit;
        }
      
        // Метод позволяет получить значение бита состояния регистра (ячейки)
        // по индексу слева (старший бит имеет индекс 0).      
        public byte GetBit(byte leftInd)
        {
            //индекс справа
            byte rightInd = Convert.ToByte(BitCount - 1 - leftInd);

            // маска вида 000010000, где единица имеет индекс получаемого бита
            // единица сдвигается влево на (индекс младшего разряда минус индекс получаемого)
            // пример: состояние 10010, получаем бит по индексу 2, сдвиг влево на (4-2) 2 разряда
            // маска 00100
            uint subsetMask = Convert.ToUInt32(1 << rightInd);
            // результат побитового И состояния и subsetMask сдвигается вправо до младшего разряда
            // остается битовое значение - 0 или 1
            return Convert.ToByte((State & subsetMask) >> rightInd);
        }
     
        // Метод позволяет установить значение бита состояния регистра (ячейки)
        // по индексу слева (старший бит имеет индекс 0).      
        private void SetBit(byte leftInd, byte value)
        {
            // индекс справа
            byte rightInd = Convert.ToByte(BitCount - 1 - leftInd);
            
            uint setMask;

            // устанавливаем 0
            if (value == 0)
            {
                // маска вида 111101111, где ноль имеет индекс устанавливаемого бита
                // единица сдвигается влево на (индекс младшего разряда минус индекс получаемого)
                // применяется операция "маска из единиц XOR маска вида 000010000", 
                // результат которой будет похож на 111101111
                setMask = OnesMask ^ Convert.ToUInt32(1 << rightInd);
                // состоянию регистра присваивается результат операции 
                // "состояние ПОБИТОВОЕ И setMask"
                State &= setMask;
            }
            // устанавливаем 1 
            else
            {
                // маска вида 000010000, где единица имеет индекс получаемого бита
                setMask = Convert.ToUInt32(1 << rightInd);
                // состоянию регистра присваивается результат операции 
                // "состояние ПОБИТОВОЕ ИЛИ setMask"
                State |= setMask;
            }
        }      
              
        // Циклический сдвиг.        
        private void CircShift()
        {
            // shiftBit - бит старшего разряда
            byte shiftBit = GetBit(0);
            // старший разряд обнуляется
            SetBit(0, 0);
            // сдвиг влево и добавление '0' справа 
            State <<= 1;
            // значение старшего разряда переносится в добавленный
            SetBit(Convert.ToByte(BitCount - 1), shiftBit); 
        }

        #endregion
    }
}
