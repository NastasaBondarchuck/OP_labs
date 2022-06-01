using System;
using System.Collections.Generic;
using System.Timers;

namespace lab5_cs
{
    public class Functions
    {
        public static string Correction(int num)
        {
            string num_ = Convert.ToString(num);
            if (num < 10 && num >= 0) { num_ = "0" + Convert.ToString(num); }
            else if (num < 0 && num > -10) { num_ = "-0" + Convert.ToString(-num); }
            return num_;
        }

        public static int ChooseYear()
        {
            Console.Write("Choose type of years (2 or 4): [yy/yyyy]     ");
            string answer = Console.ReadLine();
            while (answer != "2" && answer != "4")
            {
                Console.Write("Enter 2 or 4: ");
                answer = Console.ReadLine();
            }
            return answer=="2" ? 100 : 2030;
        }

        public static List<Date> CreateDates(int year)
        {
            Random rand = new Random();
            List<Date> DatesList = new List<Date>();
            Console.Write("Enter the number of dates: ");
            int datesNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < datesNum; i++)
            {
                int first = rand.Next(1,32);
                int second = rand.Next(1, 12);
                int third = rand.Next(0, year);
                Date date = new Date(first, second, third);
                DatesList.Add(date);
            }
            return DatesList;
        }

        public static List<Time> CreateTimes()
        {
            Random rand = new Random();
            List<Time> TimesList = new List<Time>();
            Console.Write("Enter the number of times: ");
            int timesNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < timesNum; i++)
            {
                int first = rand.Next(0, 100);
                int second = rand.Next(0, 60);
                int third = rand.Next(0, 60);
                Time time = new Time(first, second, third);
                TimesList.Add(time);
            }
            return TimesList;
        }

        public static List<Time> Comparing(List<Date> datesList)
        {
            List<Time> timeFromDate = new List<Time>();
            var copy = new Date[datesList.Count];
            datesList.CopyTo(copy);
            foreach (var date in copy)
            {
                if (date.Third <= 59)
                { 
                    Time time = new Time(date.First, date.Second, date.Third);
                    timeFromDate.Add(time);
                    datesList.Remove(date);
                }
            }

            if (timeFromDate.Count == 0)
            {
                Time time = new Time(01, 01, 01);
                timeFromDate.Add(time);
            }
            return timeFromDate;
        }
        
    }
}