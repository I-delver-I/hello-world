using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proper_fraction
{
    public class ProperFraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public ProperFraction(string rawFraction)
        {
            int[] data = rawFraction.Split(':').Select(number => int.Parse(number)).ToArray();
            Numerator = data[0];
            Denominator = data[1];
        }

        public static bool operator>(ProperFraction first, ProperFraction second)
        {
            return (double)first.Numerator / first.Denominator > (double)second.Numerator / second.Denominator;
        }

        public static bool operator<(ProperFraction first, ProperFraction second)
        {
            return (double)first.Numerator / first.Denominator < (double)second.Numerator / second.Denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}:{Denominator}";
        }
    }
}