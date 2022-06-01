using System;
using System.Collections.Generic;

namespace lab5_cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int year = Functions.ChooseYear();
            List<Date> DatesList = Functions.CreateDates(year);
            List<Time> TimesList = Functions.CreateTimes();
            Console.WriteLine("\nList of random dates: ");
            foreach (var date in DatesList) { date.DateValidation(); date.PrintDate(); }
            Console.WriteLine("\nList of random times: ");
            foreach (var time in TimesList) { time.PrintTime(); }

            List<Time> TimeFromDate = Functions.Comparing(DatesList);
            Console.WriteLine("\nList of dates, which can be times: " +
                              "\nIf list haven't got any date, you will see '01:01:01'. ");
            foreach (var time in TimeFromDate) { time.PrintTime(); }
            Console.WriteLine("\nReduced dates: ");
            foreach (var date in DatesList) { date.ReduceFirst(5); date.PrintDate(); }
            Console.WriteLine("\nIncreased times: ");
            foreach (var time in TimesList) { time.IncreaseSecond(15); time.PrintTime(); }
            Console.ReadLine();
        }
    }
}