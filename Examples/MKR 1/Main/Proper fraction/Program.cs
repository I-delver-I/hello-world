using System;

namespace Proper_fraction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProperFraction first = new ProperFraction("3:100");
            ProperFraction second = new ProperFraction("3:10");

            System.Console.WriteLine($"The first fraction is {first}");
            System.Console.WriteLine($"The second fraction is {second}");

            if (first > second)
            {
                System.Console.WriteLine($"The {first} is bigger than {second}");
            }
            else if (first < second)
            {
                System.Console.WriteLine($"The {second} is bigger than {first}");
            }
            else
            {
                System.Console.WriteLine($"The {first} and {second} are equal");
            }
        }
    }
}