using System;

namespace Custom_Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomStack<int> stack = StackCapturer.CaptureStack();

            System.Console.WriteLine($"Pop from stack {stack.Pop()}");

            foreach (var item in stack)
            {
                System.Console.WriteLine(item);
            }

            //stack.Print();
        }
    }
}