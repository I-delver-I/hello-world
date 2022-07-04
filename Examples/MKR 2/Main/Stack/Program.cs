using System;
using System.Text;

namespace Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int stackLength = 100;
            CustomStack<int> stack = new CustomStack<int>(stackLength);

            D3 d3 = new D3(23, 45, 11, new D2(93, new B1(61), 369));
            System.Console.WriteLine($"d3 is {d3}");

            foreach (char letter in d3.PropD3.ToString())
            {
                string strLetter = letter.ToString();
                stack.Push(int.Parse(strLetter));
            }
            System.Console.WriteLine("PropD3 in stack:");
            PrintStack(stack);
            d3.PropD3 = GetNumberFromStack(stack);
            System.Console.WriteLine($"Number from stack is {d3.PropD3}");

            foreach (char letter in d3.PropD1.ToString())
            {
                string strLetter = letter.ToString();
                stack.Push(int.Parse(strLetter));
            }
            System.Console.WriteLine("PropD1 in stack:");
            PrintStack(stack);
            d3.PropD1 = GetNumberFromStack(stack);
            System.Console.WriteLine($"Number from stack is {d3.PropD1}");

            foreach (char letter in d3.PropB1.ToString())
            {
                string strLetter = letter.ToString();
                stack.Push(int.Parse(strLetter));
            }
            System.Console.WriteLine("PropB1 in stack:");
            PrintStack(stack);
            d3.PropB1 = GetNumberFromStack(stack);
            System.Console.WriteLine($"Number from stack is {d3.PropB1}");        
        }

        static void PrintStack(CustomStack<int> stack)
        {
            foreach (int number in stack)
            {
                System.Console.WriteLine($"{number} ");
            }
        }

        static uint GetNumberFromStack(CustomStack<int> stack)
        {
            StringBuilder result = new StringBuilder();

            for (var i = 0; i <= stack.Count; i++)
            {
                result.Append(stack.Pop());
            }

            return uint.Parse(result.ToString());
        }
    }
}