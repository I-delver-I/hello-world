using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack
{
    public class B2
    {
        public uint PropB2 { get; set; }

        public B2(uint propB2)
        {
            PropB2 = propB2;
        }

        public override string ToString()
        {
            return $"PropB2 - {PropB2}";
        }
    }
}