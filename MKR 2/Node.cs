using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MKR_2
{
    public class Node
    {
        public int Number { get; set; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public Node Parent { get; set; }

        public Node(int number)
        {
            Number = number;
        }
    }
}