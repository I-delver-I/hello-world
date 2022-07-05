using System;

namespace Open_hash_table
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            System.Console.WriteLine("Hashtable itself: ");
            table.Add(32);
            table.Add(33);
            table.Add(32);
            table.Add(1);
            table.Add(100);
            table.Print();

            table.DeleteValue(1);
            table.DeleteValue(32);
            System.Console.WriteLine("Hashtable after removing of value: ");
            table.Print();
        }
    }
}