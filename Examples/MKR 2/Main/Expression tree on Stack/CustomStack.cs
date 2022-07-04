using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expression_tree_on_Stack
{
    public class CustomStack<T>
    {
        private ListNode<T> _head;
        private int _count;
        public int Count => _count;
        public bool IsEmpty => _head is null;

        public void Push(T item)
        {
            ListNode<T> node = new ListNode<T>(item);
            node.Next = _head;
            _head = node;
            _count++;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                return default;
            }

            ListNode<T> temp = _head;
            _head = _head.Next;
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
            ListNode<T> current = _head;

            while (current != null)
            {
                System.Console.WriteLine($"{current.Data} ");
                current = current.Next;
            }
        }
    }
}