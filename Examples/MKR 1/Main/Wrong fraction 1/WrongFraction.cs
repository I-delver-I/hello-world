using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wrong_fraction_1
{
    public class WrongFraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public WrongFraction(string rawRational)
        {
            int[] numbers = rawRational.Split(':').Select(number => int.Parse(number)).ToArray();
            Numerator = numbers[0];
            Denominator = numbers[1];
        }

        public WrongFraction()
        {
            
        }

        public static WrongFraction operator*(WrongFraction firstRational, WrongFraction secondRational)
        {
            WrongFraction result = new WrongFraction() 
            {   
                Numerator = firstRational.Numerator * secondRational.Numerator, 
                Denominator = firstRational.Denominator * secondRational.Denominator 
            };

            return result;
        }

        public void ShrinkFraction()
        {
            int gcdNum = Gcd();

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

        public override string ToString()
        {
            return $"{Numerator}:{Denominator}";
        }
    }
}