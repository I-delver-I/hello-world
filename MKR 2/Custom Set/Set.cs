using System;
using System.Collections.Generic;
//using System.Linq;
using System.Threading.Tasks;

namespace Custom_Set
{
    public class Set
    {
        public const int MaxSize = 256;
        private uint[] _arr;
        private int _size;

        public Set()
        {
            _arr = new uint[MaxSize];
            _size = 0;
        }

        public void AddValue(uint valueToAdd)
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

        public uint Find(uint valueToFind)
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

        public uint Begin()
        {
            return _arr[0];
        }

        public uint End()
        {
            return _arr[^1];
        }

        public Set Union(Set mnozhyna)
        {
            Set result = new Set();
            result._size = _size + mnozhyna._size;
            result._arr = GetElements().Union(mnozhyna.GetElements()).ToArray();
            
            return result;
        }

        public Set Except(Set mnozhyna)
        {
            Set result = new Set();
            result._arr = _arr.Except(mnozhyna._arr).ToArray();
            result._size = result._arr.Length;

            return result;
        }

        public uint[] GetElements()
        {
            uint[] result = new uint[_size];

            for (var i = 0; i < _size; i++)
            {
                result[i] = _arr[i];
            }

            return result;
        }

        public static Set Generate(int size, uint min, uint max)
        {
            Set result = new Set();
            Random random = new Random();
            result._size = size;

            for (var i = 0; i < result._size; i++)
            {
                result.AddValue((uint)random.Next(0, (int)(max - min + 1)) + min);
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