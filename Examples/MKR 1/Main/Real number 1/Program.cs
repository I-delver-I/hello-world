using System;

namespace Real_number_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RealNumber first = new RealNumber("10,23");
            RealNumber second = new RealNumber("10,23");
            
            if (first > second)
            {
                System.Console.WriteLine($"{first} is bigger than {second}");
            }
            else if (first < second)
            {
                System.Console.WriteLine($"{first} is less than {second}");
            }
            else
            {
                System.Console.WriteLine($"{first} and {second} are equal");
            }
        }
    }
}