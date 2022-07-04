using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set_2
{
    public class D2
    {
        public int PropD2 { get; set; }
        private B _b;

        public D2()
        {
            Random random = new Random();
            PropD2 = random.Next();
            _b = new B();
            _b.PropB = random.Next();
        }

        public override string ToString()
        {
            return $"PropD2 - {PropD2}, B - {_b}";
        }
    }
}