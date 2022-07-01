using System;
using System.Collections.Generic;
using System.Collections;

namespace Preparation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mnozhyna S2 = new Mnozhyna();
            D2 d2 = new D2(23, 54, new B1(77), 19);
            
            S2.AddValue(d2.AttrB2);
            S2.AddValue(d2.AttrD1);
            S2.AddValue(d2.AttrD2);
            System.Console.WriteLine("The S2 mnozhyna:");
            S2.Print();
            
            Mnozhyna S3 = new Mnozhyna();
            D3 d3 = new D3(111, new D1(99, new B1(90), 187));
            S3.AddValue(d3.AttrD3);
            System.Console.WriteLine("The S3 mnozhyna:");
            S3.Print();

            Mnozhyna S = S2.Union(S3);
            System.Console.WriteLine("Mnozhyna S:");
            S.Print();
            Mnozhyna exception = S.Except(S2);
            System.Console.WriteLine("Mnozhyna exception:");
            exception.Print();
        }
    }
}