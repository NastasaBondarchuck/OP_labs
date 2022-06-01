using System;
using System.Linq;
using System.Security.Cryptography;

namespace lab5_cs
{
    public class Date : Triad
    {
        //first - days, second - months, third - years;
        
        private int[] Days31 = {1, 3, 5, 7, 8, 10, 12};
        private int[] Days30 = {4, 6, 9, 11};
        public Date(int first, int second, int third) : base(first, second, third) { }

        public void DateValidation()
        {
            if (First > 30 && Days30.Contains(Second)) { int num = First - 29; First = 29; IncreaseFirst(num); }
            else if (First > 31 && Days31.Contains(Second)) { int num = First - 30; First = 30; IncreaseFirst(num); }
            else if (First > 27 && Second == 2) { int num = First - 27; First = 27; IncreaseFirst(num); }
        }
        public override void IncreaseFirst(int num)
        {
            for (int i = 0; i < num; i++)
            {
                First++;
                if (Days30.Contains(Second)) { if (First == 30) { IncreaseSecond(1); First = 0; } }
                else if (Days31.Contains(Second)) { if (First == 31) { IncreaseSecond(1); First = 0; } }
                else { if (First == 28) { IncreaseSecond(1); First = 0; } }
            }
        }
        public override void IncreaseSecond(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Second++;
                if (Second == 12) { IncreaseThird(1); Second = 0; }
            }
        }
        public override void IncreaseThird(int num) { Third += num; }

        public override void ReduceFirst(int num)
        {
            for (int i = 0; i < num; i++)
            {
                First--;
                if (First == 0)
                {
                    if (Days30.Contains(Second-1)) { ReduceSecond(1); First = 30; }
                    else if (Days31.Contains(Second-1)) { ReduceSecond(1); First = 31; }
                    else { ReduceSecond(1); First = 28; }
                }
            }
        }
        public override void ReduceSecond(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Second--;
                if (Second == 0) { Third--; Second = 12; }
            }
        }
        public override void ReduceThird(int num) { Third -= num; }
        
        public void PrintDate()
        {
            Console.WriteLine($"{Functions.Correction(First)}.{Functions.Correction(Second)}.{Functions.Correction(Third)}");
        }
    }
}