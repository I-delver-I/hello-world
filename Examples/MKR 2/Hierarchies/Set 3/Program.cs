using System;

namespace Set_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            D3 d3 = new D3('d', new D1('y', 'm'));
            System.Console.WriteLine($"d3 is: {d3}");

            D4 d4 = new D4('q', 'w', new B('b'));
            System.Console.WriteLine($"d4 is: {d4}");

            Set_Char C3 = new Set_Char();
            C3.AddValue(d3.PropD3);
            System.Console.WriteLine($"C3 is:");
            C3.Print();

            Set_Char C4 = new Set_Char();
            C4.AddValue(d4.PropD2);
            C4.AddValue(d4.PropD4);
            System.Console.WriteLine($"C4 is:");
            C4.Print();

            Set_Char C = C3.Union(C4);
            System.Console.WriteLine($"C is:");
            C.Print();

            System.Console.WriteLine("ASCII numbers of C symbols:");
            foreach (char symbol in C.GetElements())
            {
                System.Console.Write($"{(int)symbol} ");
            }
            System.Console.WriteLine();

            char biggestASCIIsymbol = C.GetBiggestASCIIsymbol();
            System.Console.WriteLine($"The biggest ASCII symbol within C is: {biggestASCIIsymbol}");
        }
    }
}