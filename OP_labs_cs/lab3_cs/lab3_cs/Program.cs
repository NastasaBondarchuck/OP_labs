using System;

namespace lab3_cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates of vectors: ");
            Vector[] array = Functions.CreateArray();
            Vector maxVector = Functions.FindLongest(array);
            Functions.Print(array, maxVector);
        }
    }
}