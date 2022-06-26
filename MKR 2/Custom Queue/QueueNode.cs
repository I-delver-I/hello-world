using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Queue
{
    public class QueueNode
    {
        public int Data { get; set; }
        public QueueNode Next { get; set; }

        public QueueNode(int data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return $"{Data}";
        }
    }
}