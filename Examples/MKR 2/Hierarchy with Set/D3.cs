using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preparation
{
    public class D3
    {
        public uint AttrD3 { get; set; }
        private D1 _d1;

        public D3(uint attrD3, D1 d1)
        {
            AttrD3 = attrD3;
            _d1 = d1;
        }
    }
}