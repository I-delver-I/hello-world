using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Linked_List
{
    public class CircularListNode<T>
    {
        public T Data { get; set; }
        public CircularListNode<T> Next { get; set; }
        
        public CircularListNode(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return $"{Data}";
        }
    }
}