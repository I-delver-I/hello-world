using System;

namespace Custom_Dequeue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomDequeue<string> deq = new CustomDequeue<string>();

            deq.AddFirst("horn");
            deq.AddLast("me");
            System.Console.WriteLine($"Removed value {deq.RemoveLast()}");

            System.Console.WriteLine("Dequeue itself:");
            PrintDeq(deq);
        }

        static void PrintDeq(CustomDequeue<string> deq)
        {
            foreach (var item in deq)
            {
                System.Console.WriteLine($"{item} ");
            }
        }      
    }
}