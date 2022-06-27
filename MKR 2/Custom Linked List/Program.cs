using System;

namespace Custom_Linked_List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CustomLinkedList<string> list = new CustomLinkedList<string>();
            // list.AddNode("oh");
            // list.AddNode("you");
            // list.AddNode("nor");
            // list.AddNode("time");

            // list.Remove("nor");
            
            // list.Print();

            CircularLinkedList<string> list = new CircularLinkedList<string>();
            
            list.Add("first");
            list.Add("second");
            list.Add("third");
            list.Add("fourth");

            list.Remove("second");

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}