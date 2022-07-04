using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expression_tree_on_Stack
{
    public class D4
    {
        public string PropD4 { get; set; }
        protected D2 _d2;

        public D4(D2 d2, string propD4)
        {
            PropD4 = propD4;
            _d2 = d2;
        }

        public override string ToString()
        {
            return $"PropD4 - {PropD4}, D2 - {_d2}";
        }
    }
}