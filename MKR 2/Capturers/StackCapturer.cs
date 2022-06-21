using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MKR_2.Capturers
{
    public class StackCapturer
    {
        public static Stack CaptureStack()
        {
            bool exceptionIsCaught = true;
            Stack result = new Stack();

            do
            {
                exceptionIsCaught = false;

                try
                {
                    System.Console.Write("Please, enter the number to push: ");
                    result.Push(int.Parse(Console.ReadLine()));
                    System.Console.WriteLine("Hit <Backscpace> to end typing any key to continue");
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

        public static void CaptureRemovingOfStackElements(Stack stack)
        {
            do
            {
                System.Console.Write("Removed value: ");
                System.Console.WriteLine(stack.Pop());
                System.Console.WriteLine("Hit <Backscpace> to end typing any key to continue");
            }
            while (Console.ReadKey().Key != ConsoleKey.Backspace);
        }

        public static void MainCode()
        {
            Stack stack = CaptureStack();
            CaptureRemovingOfStackElements(stack);
        }
    }
}