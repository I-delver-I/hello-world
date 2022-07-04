using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_and_LinkedList
{
    public class B2
    {
        public string AttrB2 { get; set; }

        public B2(string attrB2)
        {
            AttrB2 = attrB2;
        }

        public override string ToString()
        {
            return $"AttrB2 - {AttrB2}";
        }
    }
}