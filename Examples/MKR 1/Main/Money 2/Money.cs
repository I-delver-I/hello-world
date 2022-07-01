using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Money_2
{
    public class Money
    {
        public int Hryvnas { get; set; }
        private int _kopecks;
        public int Kopecks
        {
            get => _kopecks;
            set
            {
                int kopecksInHryvna = 100;

                if (value >= kopecksInHryvna)
                {
                    Hryvnas += value / kopecksInHryvna;
                    _kopecks = value % kopecksInHryvna;
                }
                else
                {
                    _kopecks = value;
                }
            }
        }

        public Money(string rawMoney)
        {
            int[] data = rawMoney.Split(',').Select(number => int.Parse(number)).ToArray();
            Hryvnas = data[0];
            Kopecks = data[1];
        }

        public static Money operator+(Money first, Money second)
        {
            return new Money($"{first.Hryvnas + second.Hryvnas},{first.Kopecks + second.Kopecks}");
        }

        public override string ToString()
        {
            return $"{Hryvnas},{Kopecks}";
        }
    }
}