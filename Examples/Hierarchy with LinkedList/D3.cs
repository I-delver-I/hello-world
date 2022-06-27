using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_and_LinkedList
{
    public class D3
    {
        public string AttrD3 { get; set; }
        private D2 _d2;

        public D3(string attrD3, D2 d2)
        {
            AttrD3 = attrD3;
            _d2 = d2;
        }

        public override string ToString()
        {
            return $"AttrD3 - {AttrD3}, D2 - {_d2}";
        }
    }
}