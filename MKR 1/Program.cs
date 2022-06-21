namespace MKR_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            BitString firstArray = new BitString("0101110");
            System.Console.WriteLine($"First array: {firstArray}");
            BitString secondArray = new BitString("0111");
            System.Console.WriteLine($"Second array: {secondArray}");
            
            System.Console.WriteLine($"Is the first array bigger than second?\n {firstArray > secondArray}");

            firstArray.MoveBinaryLeft(2);
            System.Console.WriteLine(firstArray);

            secondArray.MoveBinaryLeft(2);
            System.Console.WriteLine(secondArray);
        }
    }
}