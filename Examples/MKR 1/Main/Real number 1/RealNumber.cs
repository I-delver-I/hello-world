using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Real_number_1
{
    public class RealNumber
    {
        public int Whole { get; set; }
        public int Fractional { get; set; }

        public RealNumber(string rawNumber)
        {
            int[] numbers = rawNumber.Split(',').Select(number => int.Parse(number)).ToArray();
            Whole = numbers[0];
            Fractional = numbers[1];
        }

        public static bool operator>(RealNumber firstNumber, RealNumber secondNumber)
        {
            return double.Parse(firstNumber.ToString()) > double.Parse(secondNumber.ToString());
        }

        public static bool operator<(RealNumber firstNumber, RealNumber secondNumber)
        {
            return double.Parse(firstNumber.ToString()) < double.Parse(secondNumber.ToString());
        }

        public override string ToString()
        {
            return $"{Whole},{Fractional}";
        }
    }
}