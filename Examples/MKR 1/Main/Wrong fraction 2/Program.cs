using System;

namespace Wrong_fraction_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MixedWrongFraction first = new MixedWrongFraction("3 10:7");
            MixedWrongFraction second = new MixedWrongFraction("1 22:2");

            System.Console.WriteLine($"The first fraction - {first}");
            System.Console.WriteLine($"The second fraction - {second}");

            MixedWrongFraction multiplication = first * second;
            System.Console.WriteLine($"The multipplication of {first} and {second} - {multiplication}");

            multiplication.Shrink();
            System.Console.WriteLine($"The multiplication after shrinking - {multiplication}");
        }
    }
}