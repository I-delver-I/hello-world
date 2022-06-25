using System;
using MKR_2.Capturers;

namespace MKR_2
{
    public class Program
    {    
        public static void Main(string[] args)
        {
            CustomLinkedList<string> list = new CustomLinkedList<string>();
            list.AddNode("second");
            list.AddNode("third");
            list.AddNode("fourth");
            list.Print();
        }

        
    }
}