using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expression_tree_on_Stack
{
    public class D2 : D1
    {
        public string PropD2 { get; set; }
        private D3 _d3;

        public D2(string propD2, string propD1, string propB2, B1 b1, B3 b3, D3 d3) : base(propD1, propB2, b1, b3)
        {
            PropD2 = propD2;
            PropD1 = propD1;
            _d3 = d3;
        }

        public override string ToString()
        {
            return $"PropD2 - {PropD2}, PropD1 - {PropD1}, PropB2 - {PropB2}, B3 - {_b3}, D3 - {_d3}";
        }
    }
}