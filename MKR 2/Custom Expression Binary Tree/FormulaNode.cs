using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Expression_Binary_Tree
{
    public class FormulaNode
    {
        public char Data { get; set; }
        public FormulaNode Left { get; set; }
        public FormulaNode Right { get; set; }

        public FormulaNode()
        {
        }

        public FormulaNode(char element)
        {
            Data = element;
        }

        public override String ToString()
        {
            return Data.ToString();
        }
    }
}