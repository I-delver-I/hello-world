using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Open_hash_table
{
    public class Hashtable
    {
        private ListNode[] table = new ListNode[short.MaxValue];

        public void Add(int valueToAdd)
        {
            short hash = Hash(valueToAdd);
            ListNode cell = table[hash];

            if (cell == null)
            {
                table[hash] = new ListNode(valueToAdd);
            }
            else
            {
                ListNode parent = FindEnd(cell);
                ListNode newNode = new ListNode(valueToAdd);
                parent.Next = newNode;
            }
        }

        private short Hash(int value)
        {
            return (short)(value % short.MaxValue);
        }

        private ListNode FindEnd(ListNode start)
        {
            while (start.Next != null)
            {
                start = start.Next;
            }

            return start;
        }

        public ListNode Find(int value)
        {
            ListNode result = table[Hash(value)];

            while (result.Data != value)
            {
                if (result.Next is null)
                {
                    return null;
                }

                result = result.Next;
            }

            return result;
        }

        private void PrintList(ListNode head)
        {
            while (head.Next != null)
            {
                System.Console.Write($"{head.Data}->");
                head = head.Next;
            }

            System.Console.WriteLine($"{head.Data}");
        }

        public void DeleteValue(int valueToDelete)
        {
            ListNode toDelete = table[Hash(valueToDelete)];
            
            if (toDelete is null)
            {
                return;
            }

            ListNode prev = toDelete;
            ListNode current = toDelete;

            while (current != null && current.Next != null)
            {
                current = current.Next;
                
                if (current.Data == valueToDelete)
                {
                    prev.Next = current.Next;
                    current = prev;
                    
                    return;
                }

                prev = current;
            }

            if (current != null && current.Data == valueToDelete)
            {
                if (current == toDelete)
                {
                    table[Hash(valueToDelete)] = null;
                }
            }
        }

        public void Print()
        {
            for (var i = 0; i < short.MaxValue; i++)
            {
                if (table[i] != null)
                {
                    PrintList(table[i]);
                }
            }
        }
    }
}