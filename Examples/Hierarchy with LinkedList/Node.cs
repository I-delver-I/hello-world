using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_and_LinkedList
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data) 
        {
            Data = data;
        }

        public override string ToString()
        {
            return $"{Data}";
        }
    }
}