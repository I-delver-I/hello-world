using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preparation
{
    public class Mnozhyna
    {
        public const int MaxSize = 256;
        private uint[] _arr;
        private int _size;

        public Mnozhyna(uint[] arr, int size)
        {
            _arr = arr;
            _size = size;
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

                while ((_arr[insertIndex] < valueToAdd) && (insertIndex < _size))
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

        
    }
}