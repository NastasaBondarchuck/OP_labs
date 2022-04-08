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
    }
    public enum SexType
    {
        Male, Female
    }
      
}