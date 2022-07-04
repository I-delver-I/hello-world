using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set_2
{
    public class D1 : B
    {
        public int PropD1 { get; set; }
        
        public D1()
        {
            Random random = new Random();
            PropD1 = random.Next();
            PropB = random.Next();
        }

        public override string ToString()
        {
            return $"PropD1 - {PropD1}, PropB - {PropB}";
        }
    }
}