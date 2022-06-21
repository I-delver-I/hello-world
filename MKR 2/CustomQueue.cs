using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MKR_2
{
    public class CustomQueue
    {
        private QueueNode _head;
        private QueueNode _tail;

        public void Enqueue(int element)
        {
            QueueNode tempNode = new QueueNode(element);

            if (_head == null)
            {
                _head = _tail = tempNode;
            }
            else
            {
                _tail.Next = tempNode;
                _tail = tempNode;
            }
        }

        public int Dequeue()
        {
            if (_head == null)
            {
                return -1;
            }

            int tempData = _head.Data;
            _head = _head.Next;

            return tempData;
        }
    }
}
