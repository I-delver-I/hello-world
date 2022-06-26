using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Stack
{
    public class StackCapturer
    {
        public static CustomStack<int> CaptureStack()
        {
            bool exceptionIsCaught = true;
            CustomStack<int> result = new CustomStack<int>();

            do
            {
                exceptionIsCaught = false;

                try
                {
                    System.Console.Write("Please, enter the number to push: ");
                    result.Push(int.Parse(Console.ReadLine()));
                    System.Console.WriteLine("Hit <Backscpace> to end typing or any key to continue");
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("You entered not a number. Try again");
                    exceptionIsCaught = true;
                }    
            }
            while (exceptionIsCaught || (Console.ReadKey().Key != ConsoleKey.Backspace));

            return result;
        }

        public static void CaptureRemovingOfStackElements(CustomStack<int> stack)
        {
            do
            {
                System.Console.Write("Removed value: ");
                System.Console.WriteLine(stack.Pop());
                System.Console.WriteLine("Hit <Backscpace> to end typing or any key to continue");
            }
            while (Console.ReadKey().Key != ConsoleKey.Backspace);
        }
    }
}