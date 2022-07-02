using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Set_2
{
    public class B
    {
        public int PropB { get; set; }

        public B()
        {
            Random random = new Random();
            PropB = random.Next();
        }

        public override string ToString()
        {
            return $"PropB - {PropB}";
        }
    }
}