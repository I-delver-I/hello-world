using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set_2
{
    public class D4 : D2
    {
        public int PropD4 { get; set; }
        private D1 _d1;

        public D4()
        {
            Random random = new Random();
            PropD2 = random.Next();
            PropD4 = random.Next();
            _d1 = new D1();
            _d1.PropD1 = random.Next();
            _d1.PropB = random.Next();
        }

        public override string ToString()
        {
            return $"PropD4 - {PropD4}, PropD2 - {PropD2}, D1 - {_d1}";
        }
    }
}