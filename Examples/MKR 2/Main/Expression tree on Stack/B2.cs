using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expression_tree_on_Stack
{
    public class B2
    {
        public string PropB2 { get; set; }

        public B2(string propB2)
        {
            PropB2 = propB2;
        }

        public override string ToString()
        {
            return $"PropB2 - {PropB2}";
        }
    }
}