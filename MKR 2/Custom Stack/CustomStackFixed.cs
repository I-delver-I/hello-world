using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Stack
{
    public class CustomStackFixed<T>
    {
        private T[] _elements; // элементы стека
        private int _count;  // количество элементов
        const int defaultCount = 10;   // количество элементов в массиве по умолчанию

        public CustomStackFixed()
        {
            _elements = new T[defaultCount];
        }

        public CustomStackFixed(int length)
        {
            _elements = new T[length];
        }

        // пуст ли стек
        public bool IsEmpty
        {
            get { return _count == 0; }
        }

        // размер стека
        public int Count
        {
            get { return _count; }
        }

        // добвление элемента
        public void Push(T item)
        {
            // если стек заполнен, выбрасываем исключение
            if (_count == _elements.Length) 
                throw new InvalidOperationException("Stack Overflow");
            _elements[_count++] = item;
        }

        // извлечение элемента
        public T Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T item = _elements[--_count];
            _elements[_count] = default(T); // сбрасываем ссылку
            return item;
        }

        // возвращаем элемент из верхушки стека
        public T Peek()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return _elements[_count - 1];
        }

        public void Print()
        {
            foreach (T element in _elements)
            {
                System.Console.WriteLine($"{element} ");
            }
        }
    }
}