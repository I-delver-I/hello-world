using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Enter the first bit string:");
            string strToConvert1 = Console.ReadLine();
            System.Console.WriteLine("Enter the second bit string:");
            string strToConvert2 = Console.ReadLine();
            
            BitStringModel test1 = new BitStringModel(strToConvert1);
            BitStringModel test2 = new BitStringModel(strToConvert2);

            PrintComparingResult(test1, test2);
            
            System.Console.WriteLine(strToConvert1);
            System.Console.WriteLine(test1);
            System.Console.WriteLine($"First bit string {test1.ToDec()}");

            System.Console.WriteLine(test2);
            System.Console.WriteLine($"Second bit string {test2.ToDec()}");

            System.Console.WriteLine("Shift test:");
            System.Console.WriteLine(test1 << 2);
        }

        static void PrintComparingResult(BitStringModel first, BitStringModel second)
        {
            if (first > second)
            {
                System.Console.WriteLine($"The {first} bit string is bigger than {second}");
            }
            else if (first < second)
            {
                System.Console.WriteLine($"The {first} bit string is less than {second}");
            }
            else
            {
                System.Console.WriteLine($"The bit strings {first} and {second} are equal");
            }
        }
    }
}
