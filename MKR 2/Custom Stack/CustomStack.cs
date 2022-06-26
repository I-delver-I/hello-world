using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private Node<T> _head;
 
        public bool IsEmpty => _count == 0;
        private int _count;
        public int Count => _count;
 
        public void Push(T item)
        {
            // увеличиваем стек
            Node<T> node = new Node<T>(item);
            node.Next = _head; // переустанавливаем верхушку стека на новый элемент
            _head = node;
            _count++;
        }

        public T Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            Node<T> temp = _head;
            _head = _head.Next; // переустанавливаем верхушку стека на следующий элемент
            _count--;
            return temp.Data;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            return _head.Data;
        }
 
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public void Print()
        {
            foreach (var element in this)
            {
                System.Console.WriteLine($"{element} ");
            }
        }
    }
}