using System;
using System.Collections.Generic;

namespace lab2_cs
{
    public class ContentFunctions
    {
        public static void EnterAbits(string fileName)
        {
            string checkEntering;
            do
            {
                Console.WriteLine("\nEnter abit's fullname: ");
                string fullName = Console.ReadLine();
                Console.WriteLine("Enter abit's birthday: [dd.mm.yyyy]");
                string birthDay = Console.ReadLine();
                Console.WriteLine("Enter abit's sex: [m/f]");
                string Sex = Console.ReadLine();
                FileFunctions.WriteToFile(fileName, fullName, birthDay, Sex);
                Console.WriteLine("\nContinue entering?" +
                                  "\n[y/n]");
                checkEntering = Console.ReadLine();
            } while (checkEntering == "y" || checkEntering == "Y");
        }
        public static int[] SplitBirthday(string birthStr)
        {
            string[] splitedStr = birthStr.Split('.');
            int[] birthArr = {
                Convert.ToInt32(splitedStr[0]),
                Convert.ToInt32(splitedStr[1]),
                Convert.ToInt32(splitedStr[2])
            };
            return birthArr;
        }
        private static int Age(DateTime birthDay)
        {
            DateTime now = DateTime.Now;
            int age = now.Subtract(birthDay).Days / 365;
            return age;
        }
        public static List<Abit> DeleteOldAbit(List<Abit> AbitsList)
        {
            List<Abit> youngAbits = new List<Abit>();
            foreach (var abit in AbitsList)
            {
                int age = Age(abit.BirthDay);
                if (age <= 35)
                {
                    youngAbits.Add(abit);
                }
            }

            return youngAbits;
        }
        public static void PrintList(List<Abit> AbitsList)
        {
            foreach (var abit in AbitsList)
            {
                Console.WriteLine("\nFull name: " +
                                  abit.FullName +
                                  "\nBirthday: " +
                                  abit.BirthDay.ToString("d") +
                                  "\nSex: " +
                                  abit.Sex);
                
            }
        }
        public static void CreateRecruitList(List<Abit> AbitsList, string fileName)
        {
            foreach (var abit in AbitsList)
            {
                int age = Age(abit.BirthDay);
                if (abit.Sex == Abit.SexType.Male && age >= 18 && age <= 27)
                {
                    FileFunctions.WriteToFile(fileName, abit.FullName, abit.BirthDay.ToString("d"), abit.Sex.ToString());
                }
            }
        }
    }
}