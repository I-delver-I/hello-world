using System;

namespace Custom_Queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomQueue queue = new CustomQueue();
            queue.Enqueue(234);
            queue.Enqueue(1);
            queue.Enqueue(2983);
            queue.Enqueue(999);

            System.Console.WriteLine($"Dequeue test: {queue.Dequeue()}");
            
            queue.Print();
        }
    }
}