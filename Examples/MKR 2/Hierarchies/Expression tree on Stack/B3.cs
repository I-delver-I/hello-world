using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expression_tree_on_Stack
{
    public class B3
    {
        public string PropB3 { get; set; }

        public B3(string propB3)
        {
            PropB3 = propB3;
        }

        public override string ToString()
        {
            return $"PropB3 - {PropB3}";
        }
    }
}