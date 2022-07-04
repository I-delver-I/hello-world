using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private T[] _elements;
        private int _count;
        public int Count => _count;
        public bool IsEmpty => _count == 0;
    
        const int defaultCount = 10;

        public CustomStack()
        {
            _elements = new T[defaultCount];
        }

        public CustomStack(int length)
        {
            _elements = new T[length];
        }

        public void Push(T element)
        {
            if (_count == _elements.Length)
            {
                throw new InvalidOperationException("Stack Overflow");
            }

            _elements[_count++] = element;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T item = _elements[--_count];
            _elements[_count] = default(T);

            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            int i = 0;

            foreach (T element in _elements)
            {
                if (i == _count)
                {
                    break;
                }

                yield return element;
                i++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<T>)_elements.GetEnumerator();
        }
    }
}