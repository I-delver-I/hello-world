using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MKR_2.Nodes;

namespace MKR_2
{
    public class CustomLinkedList
    {
        public CustomLinkedListNode Head { get; set; }
        
        internal void InsertLast(CustomLinkedList singleList, int data)    
        {    
            CustomLinkedListNode node = new CustomLinkedListNode(data);  

            if (singleList.Head == null) 
            {    
                singleList.Head = node;  

                return;    
            }    

            CustomLinkedListNode lastNode = GetLastNode(singleList);    
            lastNode.Next = node;    
        }

        public CustomLinkedListNode GetLastNode(CustomLinkedList singleList) 
        {  
            CustomLinkedListNode tempList = singleList.Head;  

            while (tempList.Next != null) 
            {  
                tempList = tempList.Next;  
            }  

            return tempList;  
        }

        internal void DeleteNodebyKey(CustomLinkedList singlyList, int key)  
        {  
            CustomLinkedListNode temp = singlyList.Head;  
            CustomLinkedListNode prev = null;  

            if (temp != null && temp.Data == key) 
            {  
                singlyList.Head = temp.Next;  

                return;  
            }  
            
            while (temp != null && temp.Data != key) 
            {  
                prev = temp;  
                temp = temp.Next;  
            }  

            if (temp == null) 
            {  
                return;  
            }  
            prev.Next = temp.Next;  
        }  
    }
}