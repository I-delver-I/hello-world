using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack
{
    public class D2 : B2
    {
        public uint PropD2 { get; set; }
        protected B1 _b1;

        public D2(uint propD2, B1 b1, uint propB2) : base(propB2)
        {
            PropD2 = propD2;
            _b1 = b1;
        }

        public override string ToString()
        {
            return $"PropD2 - {PropD2}, B1 - {_b1}, PropB2 - {PropB2}";
        }
    }
}