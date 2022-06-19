namespace lab6_cs
{
    public class Node
    {
        public int Value { get; set; }
        public Node Right;
        public Node Left;

        public Node(int value)
        {
            this.Value = value;
            Right = null;
            Left = null;
        }
    }
}