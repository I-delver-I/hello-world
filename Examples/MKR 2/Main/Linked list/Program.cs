using System;

namespace Classes_and_LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomList<string> L = new CustomList<string>();

            D3 d3 = new D3("firstd333", new D2("firstd2", new D1("firstd1", new B2("firstb2"), "secondd1")));
            D4 d4 = new D4("firstd412121", "second4", new D1("thirdd1", new B2("secondb2"), "fourthd1"));

            L.AddNode(d3.AttrD3);
            L.AddNode(d4.AttrD2);
            L.AddNode(d4.AttrD4);

            System.Console.WriteLine("The list itself:");
            L.Print();

            L = SortByDigitsCount(L);

            System.Console.WriteLine("The list after sorting:");
            L.Print();
        }

        static CustomList<string> SortByDigitsCount(CustomList<string> list)
        {
            string[] listContent = new string[list.Count];
            Node<string> current = list.Head;
            int i = 0;

            while (current != null)
            {
                listContent[i] = current.Data;
                current = current.Next;
                i++;
            }

            listContent = listContent.OrderBy(word => word.Count(letter => Char.IsDigit(letter))).ToArray();

            return new CustomList<string>(listContent);
        }

        static string CaptureNode()
        {
            System.Console.WriteLine("Enter a word:");
           
            return Console.ReadLine();
        }

        static CustomList<string> CaptureList()
        {
            CustomList<string> list = new CustomList<string>();

            do
            {
                list.AddNode(CaptureNode());
                System.Console.WriteLine("Hit <Backspace> to end typing or any other key to continue");
            }
            while (Console.ReadKey().Key != ConsoleKey.Backspace);

            return list;
        }
    }
}