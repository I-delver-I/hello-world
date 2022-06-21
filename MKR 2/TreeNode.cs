using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MKR_2
{
    public class TreeNode
    {
        public int Number { get; set; }
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }
        public TreeNode Parent { get; set; }

        public TreeNode(int number)
        {
            Number = number;
        }
    }
}