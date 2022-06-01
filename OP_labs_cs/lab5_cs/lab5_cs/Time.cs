using System;

namespace lab5_cs
{
    public class Time :  Triad
    {
        //first - hours, second - minutes, third - seconds;
        public Time(int first, int second, int third) : base(first, second, third) { }
        
        public override void IncreaseThird(int num)
        {
            for (int i = 0; i < num; i++)
            { Third++; if (Third == 60) { IncreaseSecond(1); Third = 0; } }
        }
        
        public override void IncreaseSecond(int num)
        {
            for (int i = 0; i < num; i++)
            { Second++; if (Second == 60) { IncreaseFirst(1); Second = 0; } }
        }

        public override void IncreaseFirst(int num) { First += num; }

        public override void ReduceThird(int num)
        {
            for (int i = 0; i < num; i++)
            { Third--; if (Third == 0) { ReduceSecond(1); Third = 60; } }
        }

        public override void ReduceSecond(int num)
        {
            for (int i = 0; i < num; i++)
            { Second--; if (Second == 0) { ReduceFirst(1); Second = 60; } }
        }

        public override void ReduceFirst(int num) { First -= num; }

        public void PrintTime()
        {
            Console.WriteLine($"{Functions.Correction(First)}:{Functions.Correction(Second)}:{Functions.Correction(Third)}");
        }
    }
}