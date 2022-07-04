using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack
{
    public class B1
    {
        public uint PropB1 { get; set; }

        public B1(uint propB1)
        {
            PropB1 = propB1;
        }

        public override string ToString()
        {
            return $"PropB1 - {PropB1}";
        }
    }
}