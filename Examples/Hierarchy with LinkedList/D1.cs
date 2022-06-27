using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_and_LinkedList
{
    public class D1 : B1
    {
        public string AttrD1 { get; set; }
        protected B2 _b2;

        public D1(string attrD1, B2 b2, string attrB1) : base(attrB1)
        {
            AttrD1 = attrD1;
            _b2 = b2;
        }

        public override string ToString()
        {
            return $"AttrD1 - {AttrD1}, B2 - {_b2}";
        }
    }
}