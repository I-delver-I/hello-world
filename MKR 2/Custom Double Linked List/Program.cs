using System;

namespace Custom_Double_Linked_List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CustomDoubleLinkedList<string> list = new CustomDoubleLinkedList<string>();

            // list.Add("first");
            // list.Add("second");
            // list.Add("third");
            // list.Add("fourth");

            // list.Remove("third");

            // foreach (var item in list)
            // {
            //     System.Console.WriteLine(item);
            // }

            CircularDoubleList<string> list = new CircularDoubleList<string>();

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