using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set_3
{
    public class Set_Char
    {
        public const int MaxSize = 256;
        private char[] _arr;
        private int _size;

        public Set_Char()
        {
            _arr = new char[MaxSize];
            _size = 0;
        }

        public void AddValue(char valueToAdd)
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

        public Set_Char Union(Set_Char set)
        {
            Set_Char result = new Set_Char();
            result._size = _size + set._size;
            int currentIndex = 0;
            
            AddRange(_arr, result, ref currentIndex);
            AddRange(set.GetElements(), result, ref currentIndex);

            return result;  
        }

        public char this[int index]
        {
            get => _arr[index];
            set
            {
                _arr[index] = value;
            }
        }

        public static void AddRange(char[] range, Set_Char setToAddRange, ref int currentIndex)
        {
            List<char> filteredRange = new List<char>();

            foreach (char symbol in range)
            {
                if (symbol != '\0')
                {
                    filteredRange.Add(symbol);
                }
            }

            foreach (char symbol in filteredRange)
            {
                setToAddRange[currentIndex] = symbol;
                currentIndex++;
            }
        }

        public char GetBiggestASCIIsymbol()
        {   
            char result = _arr[0];

            foreach (char symbol in _arr)
            {
                if ((int)symbol > (int)result)
                {
                    result = symbol;
                }
            }

            return result;
        }

        public char[] GetElements()
        {
            char[] result = new char[_size];

            for (var i = 0; i < _size; i++)
            {
                result[i] = _arr[i];
            }

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