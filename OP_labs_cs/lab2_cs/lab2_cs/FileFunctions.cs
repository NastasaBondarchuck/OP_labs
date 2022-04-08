using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace lab2_cs
{
    public class FileFunctions
    {
        public static void CreateFirstFile(string fileName)
        {
            Console.WriteLine("Enter 'a' to add information to file." +
                              "\nEnter 'n' to create new file.");
            string checkFile = Console.ReadLine();
            BinaryWriter file = new BinaryWriter(File.Open(fileName, checkFile == "a" || checkFile == "A" ? FileMode.OpenOrCreate : FileMode.Create));
            file.Close();
        }
        public static void CreateSecondFile(string fileName)
        {
            BinaryWriter file = new BinaryWriter(File.Open(fileName, FileMode.Create));
            file.Close();
        }
        public static void WriteToFile(string fileName, string name, string birthday, string sex)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Append)))
            {
                writer.Write(name);
                writer.Write(birthday);
                writer.Write(sex);
            }
        }
        public static List<Abit> ReadFromFile(string fileName)
        {
            List<Abit> list = new List<Abit>();
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    string fullName = reader.ReadString();
                    int[] birthDay = ContentFunctions.SplitBirthday(reader.ReadString());
                    string Sex = reader.ReadString();
                    Abit.SexType sex = Sex == "Male" || Sex == "m" || Sex == "M" ? Abit.SexType.Male : Abit.SexType.Female;
                    Abit abit = new Abit(fullName, birthDay[0], birthDay[1], birthDay[2], sex);
                    list.Add(abit);
                }
            }

            return list;
        }
    }
}