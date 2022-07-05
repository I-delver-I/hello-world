using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private ListNode<T> _head;

        public bool IsEmpty => _head is null;
        
        public void Push(T item)
        {
            ListNode<T> node = new ListNode<T>(item);
            node.Next = _head;
            _head = node;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                return default;
            }

            ListNode<T> temp = _head;
            _head = _head.Next;
            
            return temp.Data;
        }

        public static void ReverseStack(CustomStack<string> stackToReverse)
        {
            List<string> rows = new List<string>();
            ListNode<string> current = stackToReverse._head;

            while (string row in stackToReverse)
            {
                rows.Append(row.Reverse().ToString());
            }


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
                System.Console.Write($"{current} ");
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListNode<T> current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}