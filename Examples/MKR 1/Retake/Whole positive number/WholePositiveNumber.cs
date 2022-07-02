using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whole_positive_number
{
    public class WholePositiveNumber : IEnumerable<int>
    {
        private int[] _simpleFactors;

        public int Number
        {
            get => _simpleFactors.Aggregate((x, y) => x * y);
            set
            {
                _simpleFactors = GetFactors(value);
            }
        }

        public WholePositiveNumber(int number)
        {
            _simpleFactors = (int[])GetFactors(number);
        }

        private int[] GetFactors(int number)
        {
            List<int> factors = new List<int>();
            int currentValue = 1;

            for (int factor = 1; factor <= number; factor++)
            {
                if ((number % factor == 0) && (currentValue != number))
                {
                    factors.Add(factor);
                    currentValue *= factor;
                }
            }

            return factors.ToArray();
        }

        public static int operator+(int value, WholePositiveNumber number)
        {
            return number.Number + value;
        }

        public static int operator*(int value, WholePositiveNumber number)
        {
            return number.Number * value;
        }

        public override string ToString()
        {
            return $"{_simpleFactors.Aggregate((x, y) => x * y)}";
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int factor in _simpleFactors)
            {
                yield return factor;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<int>)_simpleFactors.GetEnumerator();
        }
    }
}