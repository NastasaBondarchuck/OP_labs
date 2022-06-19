using System;

namespace lab6_cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tree tree = new Tree();
            Functions.EnterNumbers(tree);
            tree.DisplayTree();
            Functions.PrintInfo(tree);
            Console.ReadLine();
        }
    }
}