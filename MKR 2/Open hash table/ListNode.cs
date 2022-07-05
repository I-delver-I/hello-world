using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Open_hash_table
{
    public class ListNode
    {
        public int Data { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return $"{Data}";
        }
    }
}