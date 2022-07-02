using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set_2
{
    public class CustomSet
    {
        public const int MaxSize = 256;
        private int[] _arr;
        private int _size;

        public CustomSet()
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

        public int[] GetElements()
        {
            int[] result = new int[_size];

            for (var i = 0; i < _size; i++)
            {
                result[i] = _arr[i];
            }

            return result;
        }

        public CustomSet Union(CustomSet set)
        {
            CustomSet result = new CustomSet();
            result._size = _size + set._size;
            result._arr = GetElements().Union(set.GetElements()).ToArray();

            return result;
        }

        public CustomSet Except(CustomSet set)
        {
            CustomSet result = new CustomSet();
            result._arr = _arr.Except(set._arr).ToArray();
            result._size = result._arr.Length;

            return result;
        }

        public CustomSet Intersect(CustomSet set)
        {
            CustomSet result = new CustomSet();
            result._arr = _arr.Intersect(set._arr).ToArray();
            result._size = result._arr.Length;

            return result;
        }

        public void Print()
        {
            for (var i = 0; i < _size; i++)
            {
                System.Console.Write($"{_arr[i]} ");
            }

            System.Console.WriteLine();
        }
    }
}