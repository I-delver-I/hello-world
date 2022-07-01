using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wrong_fraction_3
{
    public class WrongFraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public WrongFraction(string rawFraction)
        {
            int[] data = rawFraction.Split('/').Select(number => int.Parse(number)).ToArray();
            Numerator = data[0];
            Denominator = data[1];
        }

        private int GCD()
        {
            int x = Math.Abs(Numerator);
            int y = Math.Abs(Denominator);
            int m;

            if (x > y)
            {
                m = y;
            }
            else
            {
                m = x;
            }

            for (var i = m; i >= 1; i--)
            {
                if (x % i == 0 && y % i == 0)
                {
                    return i;
                }
            }

            return 1;
        }

        public void Reduce()
        {
            int gcdNum = GCD();
            
            if (gcdNum != 0)
            {
                Numerator = Numerator / gcdNum;
                Denominator = Denominator / gcdNum;
            }

            if (Denominator < 0)
            {
                Denominator = Denominator * -1;
                Numerator = Numerator * -1;
            }
        }

        public static WrongFraction operator+(WrongFraction fraction, int valueToAdd)
        {
            fraction.Numerator += valueToAdd * fraction.Denominator;

            return fraction;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}