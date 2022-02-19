using System;
using System.IO;

namespace lab1_cs
{
    public static class FileFunc
    {
        public static void CreateInputFile(string fileName)
        {
            Console.Write("Enter 'f' to create new file  " +
                          "Enter 't' to add information to the file: ");
            string choice = Console.ReadLine();
            while (choice != "f" && choice != "F" && choice != "t" && choice != "T")
            {
                Console.Write("You've entered wrong letter. Try again, please.");
                choice = Console.ReadLine();
            }
            
            if (!File.Exists(fileName))
                File.Create(fileName).Close();
            
            Console.WriteLine("Enter text: " +
                                  "\nEnter Alt+Z to stop entering.");
            string content = EnteringContent();
            EnteringToFile(fileName, (choice == "t" ||  choice == "T"), content);
        }

        private static string EnteringContent()
        {
            bool keepEntering;
            string result = "";
            do
            {
                ConsoleKeyInfo key = Console.ReadKey();
                keepEntering = true;
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        result += "\n";
                        Console.CursorTop++;
                        break;
                    case ConsoleKey.Z when key.Modifiers == ConsoleModifiers.Alt:
                        keepEntering = false;
                        break;
                    case ConsoleKey.Backspace:
                        Console.Write(' ');
                        Console.CursorLeft--;
                        break;
                    default:
                        result += key.KeyChar.ToString();
                        break;
                }
            } while (keepEntering);
            return result;
        }

        private static void EnteringToFile(string fileName, bool mode, string content)
        {
            StreamWriter file = new StreamWriter(fileName, mode);
            file.WriteLine(content);
            file.Close();
        }

        public static void CreateOutputFile(string content, int words, int spaces, int commas, int dots, string fileName)
        {
            File.Create(fileName).Close();
            StreamWriter file = new StreamWriter(fileName, true);
            file.WriteLine(content + 
                       $"\nNumber of deleted words - {words}\n" +
                       $"\nNumber of deleted spaces - {spaces}\n" +
                       $"\nNumber of deleted commas - {commas}\n" +
                       $"\nNumber of deleted dots - {dots}\n");
            file.Close();
        }

        public static string ReadFile(string fileName)
        {
            StreamReader file = new StreamReader(fileName);
            string content = file.ReadToEnd();
            file.Close();
            return content;
        }
    }
}