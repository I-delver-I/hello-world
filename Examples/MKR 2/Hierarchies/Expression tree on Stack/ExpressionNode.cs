using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expression_tree_on_Stack
{
    public class ExpressionNode<T>
    {
        public T Data { get; set; }
        public ExpressionNode<T> Left { get; set; }
        public ExpressionNode<T> Right { get; set; }

        public ExpressionNode(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return $"{Data}";
        }
    }
}