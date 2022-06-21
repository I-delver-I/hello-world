using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MKR_2.Capturers
{
    public class QueueCapturer
    {
        public static CustomQueue CaptureQueue()
        {
            CustomQueue queue = new CustomQueue();
            bool exceptionIsCaught = false;

            do
            {
                exceptionIsCaught = false;

                try
                {
                    System.Console.Write("Enter the number to add: ");
                    queue.Enqueue(int.Parse(Console.ReadLine()));
                    System.Console.WriteLine("Hit <Backscpace> to end typing or any key to continue");
                }
                catch (FormatException)
                {
                    exceptionIsCaught = true;
                    System.Console.WriteLine("You entered not a number. Try again");
                }
            }
            while (exceptionIsCaught || Console.ReadKey().Key != ConsoleKey.Backspace);

            return queue;
        }

        public static void CaptureQueueRemovingElements(CustomQueue queue)
        {
            do
            {
                System.Console.WriteLine($"Removing of element: {queue.Dequeue()}");
                System.Console.WriteLine("Hit <Backscpace> to end typing or any key to continue"); 
            } 
            while (Console.ReadKey().Key != ConsoleKey.Backspace);
        }

        public static void MainCode()
        {
            CustomQueue capturedQueue = CaptureQueue();
            CaptureQueueRemovingElements(capturedQueue);
        }
    }
}