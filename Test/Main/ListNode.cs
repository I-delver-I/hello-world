using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_task
{
    [Serializable]
    public class ListNode
    {
        public Account Data { get; set; }
        public ListNode Next { get; set; }

        public ListNode(Account data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return $"{Data}";
        }
    }
}