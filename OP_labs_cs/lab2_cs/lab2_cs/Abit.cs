using System;

namespace lab2_cs
{
    
    public class Abit
    {
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public SexType Sex { get; set; }

        public Abit(string fullName, int day, int month, int year, SexType sex)
        {
            FullName = fullName;
            BirthDay = new DateTime(year, month, day);
            Sex = sex;
        }
        public int Age()
        {
            DateTime now = DateTime.Now;
            int age = now.Subtract(BirthDay).Days / 365;
            return age;
        }

        public string Info()
        {
            return string.Format("\nFull name: {0} \nBirthday: {1} \nSex: {2}", FullName, BirthDay.ToString("d"), Sex);
        }
        public enum SexType
        {
            Male,
            Female
        }
    }
}