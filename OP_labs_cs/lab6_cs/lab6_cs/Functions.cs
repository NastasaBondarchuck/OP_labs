using System;
using System.Collections.Generic;

namespace lab6_cs
{
    public class Functions
    {
        public static void PrintInfo(Tree tree)
        {
            Console.WriteLine("======================================================");
            Console.WriteLine($"Number of elements more than zero: {tree.counterPlus}.");
            Console.WriteLine($"Number of elements less than zero: {tree.counterMinus}.");
            Console.WriteLine(tree.isZero ? "Also there is zero element." : "There is no zero element");
            Console.WriteLine("======================================================");
        }

        public static void EnterNumbers(Tree tree)
        {
            Console.Write("Enter the number of tree's elements: ");
            int elemNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your elements (integer numbers): ");
            for (int i = 0; i < elemNumber; i++)
            {
                Console.Write($"{i+1} element: ");
                int element = Convert.ToInt32(Console.ReadLine());
                tree.AddNode(element);
            }
        }
    }
}