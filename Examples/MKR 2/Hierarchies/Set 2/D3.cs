using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set_2
{
    public class D3 : D2
    {
        public int PropD3 { get; set; }
        private D1 _d1;

        public D3()
        {
            Random random = new Random();
            PropD3 = random.Next();
            PropD2 = random.Next();
            _d1 = new D1();
            _d1.PropD1 = random.Next();
            _d1.PropB = random.Next();
        }

        public override string ToString()
        {
            return $"PropD3 - {PropD3}, PropD2 - {PropD2}, D1 - {_d1}";
        }
    }
}