using System;

namespace Direct_code
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DirectCode D1 = new DirectCode("11110000");
            System.Console.WriteLine($"The D1 is {D1} ({D1.ToDec()})");

            DirectCode D2 = new DirectCode("00001111");
            System.Console.WriteLine($"The D2 is {D2} ({D2.ToDec()})");

            int k = D1[0] + D2[0];
            int expression = 3 * (k + D1) + D2;
            System.Console.WriteLine($"The expression 3 * ({k} + {D1.ToDec()}) + {D2.ToDec()} results in {expression}");
        }
    }
}