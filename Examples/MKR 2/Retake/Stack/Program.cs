using System;

namespace Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomStack<double> stack = new CustomStack<double>();
            stack.Push(14);
            stack.Push(29);
            stack.Push(36);

            System.Console.WriteLine("Stack itself:");
            stack.Print();

            CustomStack<double> second = new CustomStack<double>();
            second.Push(22);
            second.Push(33);
            second.Push(44);
            System.Console.WriteLine("Second stack is:");
            second.Print();

            System.Console.WriteLine("Merge second and first stacks:");
            CustomStack<double> third = stack.Union(second);
            third.Print();

            // System.Console.WriteLine("Stack after reversion:");
            // CustomStack<double>.ReverseStack(stack);
            // stack.Print();
        }

        // static CustomStack<double> MergeStacks(CustomStack<double>[] stacks)
        // {

        // }
    }
}