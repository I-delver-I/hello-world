using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack
{
    public class D1 : B1
    {
        public uint PropD1 { get; set; }

        public D1(uint propD1, uint propB1) : base(propB1)
        {
            PropD1 = propD1;
        }

        public override string ToString()
        {
            return $"PropD1 - {PropD1}, PropB1 - {PropB1}";
        }
    }
}