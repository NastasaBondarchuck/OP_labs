using System;

namespace lab1_cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string inputFileName = "input.txt", outputFileName = "output.txt";
            FileFunc.CreateInputFile(inputFileName);
            string inputContent = FileFunc.ReadFile(inputFileName);
            Console.Write("\n===============================\n" +
                          "The content of the input file: " +
                          "\n===============================\n");
            Console.WriteLine(inputContent);
            string deletedContent;
            int countSpaces, countCommas, countDots, countWords;
            (deletedContent, countWords) = ContentFunc.DeleteOneSymbWords(inputContent);
            (deletedContent, countSpaces) = ContentFunc.DeleteDuplDelims(deletedContent, ' ');
            (deletedContent, countCommas) = ContentFunc.DeleteDuplDelims(deletedContent, ',');
            (deletedContent, countDots) = ContentFunc.DeleteDuplDelims(deletedContent, '.');
            FileFunc.CreateOutputFile(deletedContent, countWords, countSpaces, countCommas, countDots, outputFileName);
            string outputContent = FileFunc.ReadFile(outputFileName);
            Console.Write("\n===============================\n" +
                          "The content of the output file: " +
                          "\n===============================\n");
            Console.WriteLine(outputContent);
            Console.ReadLine();
        }
    }
}