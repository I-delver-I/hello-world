using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preparation
{
    public class D2 : D1
    {
        public uint AttrD2 { get; set; }

        public D2(uint attrD2, uint attrD1, B1 b1, uint attrB2) : base(attrD1, b1, attrB2)
        {
            AttrD2 = attrD2;
        }
    }
}