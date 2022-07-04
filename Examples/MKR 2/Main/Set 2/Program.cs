using System;

namespace Set_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            D3 d3 = new D3();
            System.Console.WriteLine($"The d3 is {d3}");

            D4 d4 = new D4();
            System.Console.WriteLine($"The d4 is {d4}");

            CustomSet M3 = new CustomSet();
            M3.AddValue(d3.PropD2);
            M3.AddValue(d3.PropD3);
            System.Console.WriteLine($"The M3 is:");
            M3.Print();
            
            CustomSet M4 = new CustomSet();
            M4.AddValue(d4.PropD2);
            M4.AddValue(d4.PropD4);
            System.Console.WriteLine($"The M4 is:");
            M4.Print();

            CustomSet M = new CustomSet();
            M = M3.Union(M4).Except(M3.Intersect(M4));
            System.Console.WriteLine($"The M is:");
            M.Print();
        }
    }
}