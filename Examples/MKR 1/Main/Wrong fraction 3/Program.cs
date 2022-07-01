using System;

namespace Wrong_fraction_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WrongFraction first = new WrongFraction("34/3");
            WrongFraction second = new WrongFraction("11/9");

            System.Console.WriteLine($"The first fraction is {first}");
            System.Console.WriteLine($"The second fraction is {second}");

            int firstValueToAdd = 6;
            first += firstValueToAdd;
            System.Console.WriteLine($"The first {first} value after increasing on {firstValueToAdd}");
            
            int secondValueToAdd = 9;
            second += secondValueToAdd;
            System.Console.WriteLine($"The second {second} value after increasing on {secondValueToAdd}");
        }
    }
}