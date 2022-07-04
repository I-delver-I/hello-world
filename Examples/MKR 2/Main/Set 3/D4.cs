using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set_3
{
    public class D4 : D2
    {
        public char PropD4 { get; set; }
        
        public D4(char propD4, char propD2, B b) : base(propD2, b)
        {
            PropD4 = propD4;
        }

        public override string ToString()
        {
            return $"PropD4 - {PropD4}, PropD2 - {PropD2}";
        }
    }
}