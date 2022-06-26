using System;

namespace Custom_Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CustomStackLinkedList<int> stack = StackCapturer.CaptureStack();

            //System.Console.WriteLine($"Pop from stack {stack.Pop()}");

            CustomStackFixed<int> stack = new CustomStackFixed<int>();
            stack.Push(243);
            stack.Push(777);
            stack.Push(793749);
            stack.Push(-432);

            System.Console.WriteLine($"Stack itself {stack}");

            stack.Print();

            System.Console.WriteLine($"Popped {stack.Pop()}");
            
            stack.Print();
        }
    }
}