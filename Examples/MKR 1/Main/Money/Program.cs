using System;

namespace Money
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Money first = new Money("34,55");
            Money second = new Money("22, 98");

            System.Console.WriteLine($"First money - {first}");
            System.Console.WriteLine($"Second money - {second}");
            System.Console.WriteLine($"Sum of {first} and {second} - {first + second}");
        }
    }
}