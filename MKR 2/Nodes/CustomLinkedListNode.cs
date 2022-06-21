using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MKR_2.Nodes
{
    public class CustomLinkedListNode 
    {  
        public int Data { get; set; }
        public CustomLinkedListNode Next { get; set; }

        public CustomLinkedListNode(int data) 
        {  
            Data = data;
        }  
    }  
}