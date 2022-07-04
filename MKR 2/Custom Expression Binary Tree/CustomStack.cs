using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Expression_Binary_Tree
{
    public class CustomStack<T>
    {
        private CustomNode<T> _head;
 
        public bool IsEmpty => _head is null;
        private int _count;
        //public int Count => _count;
 
        public void Push(T item)
        {
            // увеличиваем стек
            CustomNode<T> node = new CustomNode<T>(item);
            node.Next = _head; // переустанавливаем верхушку стека на новый элемент
            _head = node;
            _count++;
        }

        public T Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
            {
                return default;
            }

            CustomNode<T> temp = _head;
            _head = _head.Next; // переустанавливаем верхушку стека на следующий элемент
            _count--;

            return temp.Data;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                return default;
            }

            return _head.Data;
        }
 
        public void Print()
        {
            CustomNode<T> current = _head;

            while (current != null)
            {
                System.Console.Write($"{current.Data} ");
                current = current.Next;
            }
        }
    }
}