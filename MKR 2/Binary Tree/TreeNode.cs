using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class TreeNode
    {
        public int Number { get; set; }
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }

        public TreeNode(int number)
        {
            Number = number;
        }
    }
}