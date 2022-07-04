using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expression_tree_on_Stack
{
    public class D3 : B3
    {
        public string PropD3 { get; set; }

        public D3(string propB3, string propD3) : base(propB3)
        {
            PropD3 = propD3;
        }

        public override string ToString()
        {
            return $"PropD3 - {PropD3}, PropB3 - {PropB3}";
        }
    }
}