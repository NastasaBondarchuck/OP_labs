using System;

namespace lab4_cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BoolVector B1 = Functions.CreateVector();
            BoolVector B2 = new BoolVector();
            Functions.CheckLength(B1, B2);
            Functions.PrintVector(B1, "B1");
            Functions.PrintVector(B2, "B2");
            B1 = ~B1;
            Functions.PrintVector(B1, "~B1");
            BoolVector B3 = B1 & B2;
            Functions.PrintVector(B3, "B3 [B1 & B2]");
            Console.WriteLine($"The weight of B3 bool vector is: {B3.Weight()}");
            Console.ReadLine();
        }
    }
}