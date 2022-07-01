using System;

namespace Wrong_fraction_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WrongFraction firstRational = new WrongFraction("34:8");
            WrongFraction secondRational = new WrongFraction("11:2");

            WrongFraction multiplication = firstRational * secondRational;
            System.Console.WriteLine($"The multiplication of wrong rationals: {multiplication} itself");
            multiplication.ShrinkFraction();
            System.Console.WriteLine($"The shrinked multiplication of wrong rationals: {multiplication}");
        }
    }
}