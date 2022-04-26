using System.Collections.Generic;
using System.Linq;

namespace lab4_cs
{
    public class BoolVector
    {
        public List<char> Value;

        public int Length => Value.Count;

        public BoolVector()
        {
            Value = "0100110101".ToList();
        }
        public BoolVector(List<char> value)
        {
            Value = value;
        }
        public int Weight()
        {
            int weight = 0;
            foreach (var component in Value)
            {
                if (component == '1') weight++;
            }
            return weight;
        }
        
        public static BoolVector operator &(BoolVector B1, BoolVector B2)
        {
            List<char> resultValue = new List<char>();
            for (int i = 0; i < B1.Length; i++)
            {
                if (B1.Value[i] == B2.Value[i])
                {
                    resultValue.Add(B1.Value[i]);
                }
                else
                {
                    resultValue.Add('0');
                }
            }
            BoolVector B3 = new BoolVector(resultValue);
            return B3;
        }
        
        public static BoolVector operator ~(BoolVector B1)
        {
            List<char> resultValue = new List<char>();
            for (int i = 0; i < B1.Length; i++)
            {
                if (B1.Value[i] == '0')
                {
                    resultValue.Add('1');
                }
                else
                {
                    resultValue.Add('0');
                }
            }
            BoolVector B2 = new BoolVector(resultValue);
            return B2;
        }
    }
}