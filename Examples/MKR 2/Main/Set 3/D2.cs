using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set_3
{
    public class D2
    {
        public char PropD2 { get; set; }
        private B _b;

        public D2(char propD2, B b)
        {
            PropD2 = propD2;
            _b = b;
        }

        public override string ToString()
        {
            return $"PropD2 - {PropD2}, B - {_b}";
        }
    }
}