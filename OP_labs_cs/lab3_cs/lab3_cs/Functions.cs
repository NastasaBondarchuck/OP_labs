using System;
using System.Collections.Generic;

namespace lab3_cs
{
    public class Functions
    {
        public static Vector[] CreateArray()
        {
            string checkEntering;
            List<Vector> vectors = new List<Vector>();
            do
            {
                vectors.Add(EnteringCoordinates());
                Console.WriteLine("\nContinue entering? [y/n]");
                checkEntering = Console.ReadLine();
            } while (checkEntering == "y" || checkEntering == "Y");

            return vectors.ToArray();
        }

        public static Vector EnteringCoordinates()
        {
            Console.Write("\nEnter X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Vector vector = new Vector(x, y, z);
            return vector;
        }

        public static Vector FindLongest(Vector[] array)
        {
            Vector maxVector = array[0];
            foreach (var vector in array)
            {
                if (vector.GetLength() >= maxVector.GetLength()) { maxVector = vector;}
            }

            return maxVector;
        }
        public static void Print(Vector[] array, Vector maxVector)
        {
            foreach (var vector in array)
            {
                Console.WriteLine($"Coordinates: ({vector.X}; {vector.Y}; {vector.Z})\t Length: {vector.GetLength()}.");
            }
            Console.WriteLine($"The longest vector has coordinates: ({maxVector.X}; {maxVector.Y}; {maxVector.Z})\t Length: {maxVector.GetLength()}.");
        }
    }
}