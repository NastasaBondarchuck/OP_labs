using System;

namespace lab3_cs
{
    public class Vector
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public double Length
        {
            get
            {
                double length = Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2);
                return Math.Round(Math.Sqrt(length), 2);
            }
        }

        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}