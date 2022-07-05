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

            while (!stackToReverse.IsEmpty)
            {
                rows.Add(string.Join("", stackToReverse.Pop().Reverse()));
            }

            for (var i = rows.Count - 1; i >= 0; i--)
            {
                stackToReverse.Push(rows[i]);
            }
        }

        public CustomStack<T> Union(CustomStack<T> stack)
        {
            CustomStack<T> result = new CustomStack<T>();

            result.AddRange(GetElements().Reverse().ToArray());
            result.AddRange(stack.GetElements().Reverse().ToArray());

            return result;
        }

        public void AddRange(T[] range)
        {
            foreach (var item in range)
            {
                Push(item);
            }
        }

        private T[] GetElements()
        {
            List<T> result = new List<T>();
            ListNode<T> current = _head;

            while (current != null)
            {
                result.Add(current.Data);
                current = current.Next;
            }

            return result.ToArray();
        }

        public static void ReverseStack(CustomStack<double> stackToReverse)
        {
            List<double> numbers = new List<double>();

            while (!stackToReverse.IsEmpty)
            {
                numbers.Add(double.Parse(string.Join("", stackToReverse.Pop().ToString().Reverse())));
            }

            for (var i = numbers.Count - 1; i >= 0; i--)
            {
                stackToReverse.Push(numbers[i]);
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

            System.Console.WriteLine();
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