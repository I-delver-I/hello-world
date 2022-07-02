using System.Text;

namespace Direct_code
{
    public class DirectCode
    {
        private char[] _directNumber;
        private int _length;

        private DirectCode(int length)
        {
            _length = length;
            _directNumber = new char[(int)Math.Ceiling((decimal)length / (sizeof(char) * 8))];
        }

        public DirectCode(string directNumber) : this(directNumber.Length)
        {
            SetNumber(directNumber);
        }

        public void SetNumber(string directNumber)
        {
            for (var i = 0; i < directNumber.Length; i++)
            {
                int elementIndex = i / (sizeof(char) * 8);
                int bitIndex = (sizeof(char) * 8) - 1 - i % (sizeof(char) * 8);

                if (directNumber[i] == '0')
                {
                    _directNumber[elementIndex] &= (char)~(1 << bitIndex);
                }
                else if (directNumber[i] == '1')
                {
                    _directNumber[elementIndex] |= (char)(1 << bitIndex);
                }
            }
        }

        public int ToDec()
        {
            int result = 0;

            for (int i = _length, y = 1; y < _length; i--, y++)
            {
                int elementIndex = i / (sizeof(char) * 8);
                int bitIndex = (sizeof(char) * 8) - 1 - y % (sizeof(char) * 8);

                result += Convert.ToBoolean(_directNumber[elementIndex] >> bitIndex & 1) ? (int)Math.Pow(2, y) : 0;
            }

            if (ToString()[0] == '1')
            {
                result *= -1;
            }

            return result;
        }

        public char this[int index]
        {
            get
            {
                string strRepresentation = ToString();
                
                return strRepresentation[index];
            }
        }

        public static int operator+(int value, DirectCode number)
        {
            return value + number.ToDec();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (var i = 0; i < _length; i++)
            {
                int elementIndex = i / (sizeof(char) * 8);
                int bitIndex = (sizeof(char) * 8) - 1 - i % (sizeof(char) * 8);

                result.Append(Convert.ToBoolean((_directNumber[elementIndex] >> bitIndex) & 1) ? '1' : '0');
            }

            return result.ToString();
        }
    }
}