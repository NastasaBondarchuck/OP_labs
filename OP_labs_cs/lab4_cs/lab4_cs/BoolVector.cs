using System.Collections.Generic;
using System.Linq;

namespace lab4_cs
{
    public class BoolVector
    {
        public List<char> Value;

        public int Length => Value.Count;

        public BoolVector() { Value = "0100110101".ToList(); }
        
        public BoolVector(List<char> value) { Value = value; }
        
        public int Weight()
        {
            int weight = 0;
            foreach (var component in Value) if (component == '1') weight++;
            return weight;
        }
        public static BoolVector operator &(BoolVector B1, BoolVector B2)
        {
            List<char> resultValue = new List<char>();
            for (int i = 0; i < B1.Length; i++) resultValue.Add( B1.Value[i] == B2.Value[i] ? B1.Value[i] : '0');
            BoolVector B3 = new BoolVector(resultValue);
            return B3;
        }
        public static BoolVector operator ~(BoolVector B1)
        {
            List<char> resultValue = new List<char>();
            for (int i = 0; i < B1.Length; i++) resultValue.Add(B1.Value[i] == '0' ? '1' : '0'); 
            BoolVector B2 = new BoolVector(resultValue);
            return B2;
        }
    }
}