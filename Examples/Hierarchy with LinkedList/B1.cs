using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_and_LinkedList
{
    public class B1
    {
        public string AttrB1 { get; set; }

        public B1(string attrb1)
        {
            AttrB1 = attrb1;
        }

        public override string ToString()
        {
            return $"AttrB1 - {AttrB1}";
        }
    }
}