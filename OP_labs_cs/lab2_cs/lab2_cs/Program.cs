using System;
using System.Collections.Generic;

namespace lab2_cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string firstFileName = "first.bin", secondFileName = "second.bin";
            FileFunctions.CreateFirstFile(firstFileName);
            ContentFunctions.EnterAbits(firstFileName);
            List<Abit> AbitsList = FileFunctions.ReadFromFile(firstFileName, '.');
            Console.WriteLine("\n==============================="+
                              "\nList of abits: ");
            ContentFunctions.PrintList(AbitsList);
            Console.WriteLine("\n==============================="+
                              "\nList of abits younger than 35: ");
            List<Abit> YoungAbits = ContentFunctions.DeleteOldAbit(AbitsList);
            ContentFunctions.PrintList(YoungAbits);
            ContentFunctions.CreateRecruitList(AbitsList, secondFileName);
            List<Abit> RecruitsList = FileFunctions.ReadFromFile(secondFileName, '/');
            Console.WriteLine("\n==============================="+
                              "\nList of recruits: ");
            ContentFunctions.PrintList(RecruitsList);

        }
        
        
    }
}