using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_and_LinkedList
{
    public class D4 : D2
    {
        public string AttrD4 { get; set; }

        public D4(string attrD4, string attrD2, D1 d1) : base(attrD2, d1)
        {
            AttrD4 = attrD4;
        }

        public override string ToString()
        {
            return $"AttrD4 - {AttrD4}, AttrB2 - {AttrD2}, D1 - {_d1}";
        }
    }
}