using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expression_tree_on_Stack
{
    public class D1 : B2
    {
        public string PropD1 { get; set; }
        private B1 _b1;
        protected B3 _b3;

        public D1(string propD1, string propB2, B1 b1, B3 b3) : base(propB2)
        {
            PropD1 = propD1;
            _b1 = b1;
            _b3 = b3;
        }

        public override string ToString()
        {
            return $"PropD1 - {PropD1}, PropB2 - {PropB2}, B1 - {_b1}, B3 - {_b3}";
        }
    }
}