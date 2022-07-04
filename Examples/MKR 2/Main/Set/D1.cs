using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preparation
{
    public class D1 : B2
    {
        public uint AttrD1 { get; set; }
        private B1 _b1;

        public D1(uint attrD1, B1 b1, uint attrB2) : base(attrB2)
        {
            AttrD1 = attrD1;
            _b1 = b1;
        }
    }
}