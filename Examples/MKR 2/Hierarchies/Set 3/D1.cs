using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set_3
{
    public class D1 : B
    {
        public char PropD1 { get; set; }

        public D1(char propD1, char propB) : base(propB)
        {
            PropD1 = propD1;
            PropB = propB;
        }

        public override string ToString()
        {
            return $"PropD1 - {PropD1}, PropB - {PropB}";
        }
    }
}