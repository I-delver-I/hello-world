using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    public class BitStringModel
    {
        private char[] _bitArray;
        private int _length;

        private BitStringModel(int length)
        {
            _length = length;
            _bitArray = new char[(int)Math.Ceiling((decimal)length / (sizeof(char) * 8))];
        }

        public BitStringModel(string bitNumber) : this(bitNumber.Length)
        {
            SetString(bitNumber);
        }

        public static bool operator>(BitStringModel first, BitStringModel second)
        {
            return first.ToDec() > second.ToDec();
        }

        public static bool operator<(BitStringModel first, BitStringModel second)
        {
            return first.ToDec() < second.ToDec();
        }

        public static BitStringModel operator<<(BitStringModel bitString, int offense)
        {
            return new BitStringModel(Convert.ToString(bitString.ToDec() << offense, 2));
        }
        
        public void SetString(string bitNumber)
        {
            for (var i = 0; i < bitNumber.Length; i++)
            {
                int elementIndex = i / (sizeof(char) * 8);
                int bitIndex = (sizeof(char) * 8) - 1 - i % (sizeof(char) * 8);
                System.Console.WriteLine($"{elementIndex} {bitIndex} {i} {sizeof(char) * 8}");

                if (bitNumber[i] == '0')
                {
                    _bitArray[elementIndex] &= (char)~(1 << bitIndex);
                }
                else if (bitNumber[i] == '1')
                {
                    _bitArray[elementIndex] |= (char)(1 << bitIndex);
                }
            }
        }

        public int ToDec()
        {
            int result = 0;
            
            for (int i = _length - 1, y = 0; y < _length; i--, y++)
            {
                int elementIndex = i / (sizeof(char) * 8);
                int bitIndex = (sizeof(char) * 8) - 1 - y % (sizeof(char) * 8);
                result += Convert.ToBoolean(_bitArray[elementIndex] >> bitIndex & 1) ? (int)Math.Pow(2, y) : 0;
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (var i = 0; i < _length; i++)
            {
                int elementIndex = i / (sizeof(char) * 8);
                int bitIndex = (sizeof(char) * 8) - 1 - i % (sizeof(char) * 8);
                result.Append(Convert.ToBoolean((_bitArray[elementIndex] >> bitIndex) & 1) ? '1' : '0');
            }

            return result.ToString();
        }
    }
}