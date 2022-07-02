using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_and_LinkedList
{
    public class D2
    {
        public string AttrD2 { get; set; }
        protected D1 _d1;

        public D2(string attrD2, D1 d1)
        {
            AttrD2 = attrD2;
            _d1 = d1;
        }

        public override string ToString()
        {
            return $"AttrD2 - {AttrD2}, D1 - {_d1}";
        }
    }
}