using System;
using System.Linq;

namespace lab4_cs
{
    public class Functions
    {
        public static void CheckLength(BoolVector B1, BoolVector B2)
        {
            if (B1.Length > B2.Length)
            {
                int diff = B1.Length - B2.Length;
                for (int i = 0; i < diff; i++)
                {
                    B2.Value.Insert(0, '0');
                }
            }
            else if (B2.Length > B1.Length)
            {
                int diff = B2.Length - B1.Length;
                for (int i = 0; i < diff; i++)
                {
                    B1.Value.Insert(0, '0');
                }
            }
        }

        public static BoolVector CreateVector()
        {
            Console.WriteLine("Enter bool vector [contains only 0 and 1]: ");
            bool checkEntering = true;
            string vectorValue = "";
            do
            {
                vectorValue = Console.ReadLine();
                foreach (var component in vectorValue)
                {
                    if (component == '0' || component == '1') checkEntering = true;
                    else
                    {
                        checkEntering = false;
                        Console.WriteLine("Enter correct bool vector: ");
                    }
                }
            } while (!checkEntering);
            BoolVector B = new BoolVector(vectorValue.ToList());
            return B;
        }

        public static void PrintVector(BoolVector B, string vectorName)
        {
            string value = "";
            foreach (var component in B.Value) value += component;
            Console.WriteLine($"{vectorName} bool vector is: {value}");
        }
    }
}