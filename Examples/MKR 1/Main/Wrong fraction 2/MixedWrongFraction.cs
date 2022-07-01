using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wrong_fraction_2
{
    public class MixedWrongFraction
    {
        public int Whole { get; set; }
        private int _numerator;
        public int Numerator
        {
            get => _numerator;
            set
            {
                if (value >= Denominator)
                {
                    Whole += value / Denominator;
                    _numerator = value % Denominator;
                }
                else
                {
                    _numerator = value;
                }
            }
        }
        public int Denominator { get; set; }

        public MixedWrongFraction(string rawFraction)
        {
            int[] numbers = rawFraction.Split(new char[] { ' ', ':' }).Select(number => int.Parse(number)).ToArray();
            Whole = numbers[0];
            Denominator = numbers[2];
            Numerator = numbers[1];
            
        }

        public MixedWrongFraction()
        {
            
        }

        public static MixedWrongFraction operator*(MixedWrongFraction first, MixedWrongFraction second)
        {
            MixedWrongFraction result = new MixedWrongFraction();

            result.Denominator = first.Denominator * second.Denominator;
            result.Numerator = (first.Denominator * first.Whole + first.Numerator)
                * (second.Denominator * second.Whole + second.Numerator);

            return result;
        }

        private int Gcd()
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

        public void Shrink()
        {
            int gcdNum = Gcd();

            if (gcdNum != 0)
            {
                Denominator = Denominator / gcdNum;
                Numerator = Numerator / gcdNum;
            }

            if (Denominator < 0)
            {
                Denominator = Denominator * -1;
                Numerator = Numerator * -1;
            }
        }

        public override string ToString()
        {
            return $"{Whole} {Numerator}:{Denominator}";
        }
    }
}