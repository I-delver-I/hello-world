using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Linked_List
{
    public class CustomLinkedListNode<T> 
    {  
        public T Data { get; set; }
        public CustomLinkedListNode<T> Next { get; set; }

        public CustomLinkedListNode(T data) 
        {
            Data = data;
        }

        public override string ToString()
        {
            return $"{Data}";
        }
    }  
}