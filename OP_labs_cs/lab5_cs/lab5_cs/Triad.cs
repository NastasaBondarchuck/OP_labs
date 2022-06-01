namespace lab5_cs
{
    public abstract class Triad
    {
        public int First;
        public int Second;
        public int Third;
        
        protected Triad(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public abstract void IncreaseFirst(int num);
        public abstract void IncreaseSecond(int num);
        public abstract void IncreaseThird(int num);

        public abstract void ReduceFirst(int num);
        public abstract void ReduceSecond(int num);
        public abstract void ReduceThird(int num);
    }
}