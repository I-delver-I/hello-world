using System;

namespace Money_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Money first = new Money("34,56");
            Money second = new Money("1,70");

            System.Console.WriteLine($"The first money - {first}");
            System.Console.WriteLine($"The second money - {second}");

            Money sum = first + second;
            System.Console.WriteLine($"The sum of {first} and {second} is {sum}");
        }
    }
}