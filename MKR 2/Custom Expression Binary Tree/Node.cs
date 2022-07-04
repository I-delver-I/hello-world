using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Expression_Binary_Tree
{
    public class CustomNode<T>
    {
        public T Data { get; set; }
        public CustomNode<T> Next { get; set; }

        public CustomNode(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return $"{Data}";
        }
    }
}