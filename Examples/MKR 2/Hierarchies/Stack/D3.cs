using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack
{
    public class D3 : D1
    {
        public uint PropD3 { get; set; }
        protected D2 _d2;

        public D3(uint propD3, uint propD1, uint propB1, D2 d2) : base(propD1, propB1)
        {
            PropD3 = propD3;
            _d2 = d2;
        }

        public override string ToString()
        {
            return $"PropD3 - {PropD3}, PropD1 - {PropD1}, PropB1 - {PropB1}, D2 - {_d2}";
        }
    }
}