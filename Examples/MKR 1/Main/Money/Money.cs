using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Money
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
                int totalValue = _kopecks + value;

                if (totalValue >= 100)
                {
                    Hryvnas += totalValue / 100;

                    _kopecks = totalValue % 100;
                }
                else
                {
                    _kopecks += value;
                }
            }
        }

        public Money(string rawMoney)
        {
            int[] numbers = rawMoney.Split(',').Select(number => int.Parse(number)).ToArray();
            Hryvnas = numbers[0];
            Kopecks = numbers[1];
        }

        public static Money operator+(Money first, Money second)
        {
            return new Money($"{first.Hryvnas + second.Hryvnas},{first._kopecks + second._kopecks}");
        }

        public override string ToString()
        {
            return $"{Hryvnas},{Kopecks}";
        }
    }
}