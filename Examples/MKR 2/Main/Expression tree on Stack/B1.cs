using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expression_tree_on_Stack
{
    public class B1
    {
        public string PropB1 { get; set; }

        public B1(string propB1)
        {
            PropB1 = propB1;
        }

        public override string ToString()
        {
            return $"PropB1 - {PropB1}";
        }
    }
}