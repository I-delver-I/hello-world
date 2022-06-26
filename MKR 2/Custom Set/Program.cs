using System;
using System.Collections.Generic;

namespace Custom_Set
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Set set = CaptureSet();
            System.Console.WriteLine("The created set");
            set.Print();
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
                    result.AddValue(uint.Parse(Console.ReadLine()));
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