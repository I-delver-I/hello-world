using System;

namespace Whole_positive_number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WholePositiveNumber Z1 = new WholePositiveNumber(10);
            System.Console.WriteLine($"Z1 is {Z1}:");
            foreach (int number in Z1)
            {
                System.Console.WriteLine($"{number} ");
            }
            
            WholePositiveNumber Z2 = new WholePositiveNumber(23);
            System.Console.WriteLine($"Z2 is {Z2}:");
            foreach (int number in Z2)
            {
                System.Console.WriteLine($"{number} ");
            }

            System.Console.Write("Please, enter k: ");
            int k = int.Parse(Console.ReadLine());
            int expression = (k + Z1) * 2 + 5 * Z2;

            System.Console.WriteLine($"Z1 is {Z1}:");
            foreach (int number in Z1)
            {
                System.Console.WriteLine($"{number} ");
            }

            System.Console.WriteLine($"Z2 is {Z2}:");
            foreach (int number in Z2)
            {
                System.Console.WriteLine($"{number} ");
            }
            
            System.Console.WriteLine($"The result of expression ({k} + {Z1}) * 2 + 5 * {Z2} is {expression}");
        }
    }
}