namespace MKR_1
{
    public class BitString
    {
        public byte[] BitArray { get; set; } = new byte[16];

        public BitString(string bitRow)
        {
            for (var i = 0; i < bitRow.Length; i++)
            {
                BitArray[i] = (byte)(bitRow[i]);
            }
        }

        public void MoveBinaryLeft(int positionCount)
        {
            for (var i = 2; i < BitArray.Length; i++)
            {
                BitArray[i - 2] = BitArray[i];
                BitArray[i] = 0;
            }
        }

        public static bool operator<(BitString first, BitString second)
        {
            return first.ToDec() < second.ToDec();
        }

        public static bool operator>(BitString first, BitString second)
        {
            return first.ToDec() > second.ToDec();
        }

        public int ToDec()
        {
            int result = 0;

            foreach (var item in BitArray)
            {
                result += item;
            }

            return result;
        }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (var item in BitArray)
            {
                result += item.ToString();
            }

            return result;
        }
    }
}