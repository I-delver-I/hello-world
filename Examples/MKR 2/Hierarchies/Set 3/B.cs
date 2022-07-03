using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set_3
{
    public class B
    {
        public char PropB { get; set; }

        public B(char propB)
        {
            PropB = propB;
        }

        public override string ToString()
        {
            return $"PropB - {PropB}";
        }
    }
}