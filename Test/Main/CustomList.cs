using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_task
{
    [Serializable]
    public class CustomList
    {
        private ListNode _head;
        private ListNode _tail;

        public int Count { get; set; }

        public void AddNode(Account data)
        {
            ListNode node = new ListNode(data);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;
            }

            _tail = node;
            Count++;
        }

        public ListNode MaxBySum()
        {
            ListNode current = _head;
            ListNode maxNode = _head;

            while (current != null)
            {
                if (current.Data.SumaVkladu > maxNode.Data.SumaVkladu)
                {
                    maxNode = current;
                }
                
                current = current.Next;
            }

            return maxNode;
        }

        public static CustomList GetAccountsBetweenDates(CustomList list, DateTime primary, DateTime ending)
        {
            CustomList result = new CustomList();
            ListNode current = list._head;

            while (current != null)
            {
                if (current.Data.LastOperationDate >= primary && current.Data.LastOperationDate <= ending)
                {
                    result.AddNode(current.Data);
                }

                current = current.Next;
            }

            return result;
        }

        public void Print()
        {
            ListNode current = _head;

            while (current != null)
            {
                System.Console.WriteLine($"{current}");
                current = current.Next;
            }

            System.Console.WriteLine();
        }
    }
}