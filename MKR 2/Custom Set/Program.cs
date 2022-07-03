using System;
using System.Collections.Generic;

namespace Custom_Set
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Set set = CaptureSet();
            Set first = new Set();
            first.AddRange(new int[] { 1, 2, 3 });
            System.Console.WriteLine($"First set is:");
            first.Print();

            Set second = new Set();
            int[] range = new int[] { 2, 3, 10 };
            second.AddRange(range);
            System.Console.WriteLine($"Second set is:");
            second.Print();

            Set total = first.Union(second);
            System.Console.WriteLine($"total set is:");
            total.Print();

            Set exceptence = first.Except(second);
            System.Console.WriteLine($"First except from second is:");
            exceptence.Print();

            Set intersection = first.Intersect(second);
            System.Console.WriteLine($"First intersected with second is:");
            intersection.Print();
        }

        static Set CaptureSet()
        {
            Set result = new Set();
            bool exceptionIsCaught = false;

            do
            {
                exceptionIsCaught = false;
                
                try
                {
                    System.Console.Write("Enter a uint number: ");
                    result.AddValue(int.Parse(Console.ReadLine()));
                    System.Console.WriteLine("Press <Backspace> to end typing or any other key to continue");
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("You entered not a uint number. Try again");
                    exceptionIsCaught = true;
                }
            } 
            while (exceptionIsCaught || (Console.ReadKey().Key != ConsoleKey.Backspace));

            return result;
        }
    }
}