using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set_3
{
    public class D3
    {
        public char PropD3 { get; set; }
        private D1 _d1;

        public D3(char porpD3, D1 d1)
        {
            PropD3 = porpD3;
            _d1 = d1;
        }

        public override string ToString()
        {
            return $"PropD3 - {PropD3}, D1 - {_d1}";
        }
    }
}