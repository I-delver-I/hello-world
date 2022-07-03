using System;
using System.Collections.Generic;
//using System.Linq;
using System.Threading.Tasks;

namespace Custom_Set
{
    public class Set
    {
        public const int MaxSize = 256;
        private int[] _arr;
        private int _size;
        public int Size => _size;

        public Set()
        {
            _arr = new int[MaxSize];
            _size = 0;
        }

        public void AddValue(int valueToAdd)
        {
            if (_size == MaxSize)
            {
                return;
            }

            if (_size == 0)
            {
                _arr[0] = valueToAdd;
            }
            else
            {
                int insertIndex = 0;

                while (((_arr[insertIndex] < valueToAdd) && (_arr[insertIndex] != 0)) && (insertIndex < _size))
                {
                    insertIndex++;
                }

                if (_arr[insertIndex] == valueToAdd)
                {
                    return;
                }

                for (var i = _size; i > insertIndex; i--)
                {
                    _arr[i] = _arr[i - 1];
                }

                _arr[insertIndex] = valueToAdd;
            }

            _size++;
        }

        public void DeleteValue(int valueToDelete)
        {
            int deleteIndex;

            for (deleteIndex = 0; (deleteIndex < _size) && (_arr[deleteIndex] != valueToDelete); deleteIndex++)
            {
                // Incrementing of DeleteIndex
            }

            if (deleteIndex == _size)
            {
                return;
            }

            for (var i = deleteIndex; i < _size - 1; i++)
            {
                _arr[i] = _arr[i + 1];
            }

            _size--;
        }

        public int Find(int valueToFind)
        {
            for (var i = 0; i < _size; i++)
            {
                if (_arr[i] == valueToFind)
                {
                    return _arr[i];
                }
                else if (_arr[i] > valueToFind)
                {
                    return default;
                }
            }

            return default;
        }

        public int Begin()
        {
            return _arr[0];
        }

        public int End()
        {
            return _arr[^1];
        }

        public void AddRange(int[] rangeToAdd)
        {
            int[] filteredRange = RemoveZeroes(rangeToAdd);

            foreach (int number in filteredRange)
            {
                AddValue(number);
            }
        }

        public Set Intersect(Set set)
        {
            Set result = new Set();

            foreach (int firstNumber in GetElements())
            {
                foreach (int secondNumber in set.GetElements())
                {
                    if (firstNumber == secondNumber)
                    {
                        result.AddValue(firstNumber);
                    }
                }
            }

            return result;
        }

        public Set Union(Set mnozhyna)
        {
            Set result = new Set();

            result.AddRange(_arr);
            result.AddRange(mnozhyna.GetElements());
            
            return result;
        }

        public Set Except(Set mnozhyna)
        {
            Set result = new Set();
            bool alreadyThere;

            foreach (int firstNumber in GetElements())
            {
                alreadyThere = false;

                foreach (int secondNumber in mnozhyna.GetElements())
                {
                    if (firstNumber == secondNumber)
                    {
                        alreadyThere = true;
                        break;
                    }
                }

                if (!alreadyThere)
                {
                    result.AddValue(firstNumber);
                }
            }

            return result;
        }

        private int[] RemoveZeroes(int[] array)
        {
            return array.Where(number => number != default).ToArray();
        }

        public int[] GetElements()
        {
            int[] result = new int[_size];

            for (var i = 0; i < _size; i++)
            {
                result[i] = _arr[i];
            }

            return result;
        }

        public static Set Generate(int size, int min, int max)
        {
            Set result = new Set();
            Random random = new Random();
            result._size = size;

            for (var i = 0; i < result._size; i++)
            {
                result.AddValue((int)random.Next(0, (int)(max - min + 1)) + min);
            }

            return result;
        }

        public void Print()
        {
            for (var i = 0; (i < _size) && (_arr[i] != 0); i++)
            {
                System.Console.Write($"{_arr[i]} ");
            }

            System.Console.WriteLine();
        }
    }
}