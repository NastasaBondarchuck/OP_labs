using System;
using System.Diagnostics.PerformanceData;
using System.Text;

namespace lab6_cs
{
    public class Tree
    {
        public Node Root;
        public int counterPlus, counterMinus;
        public bool isZero;

        public Tree()
        {
            Root = null;
            counterPlus = 0;
            counterMinus = 0;
            isZero = false;
        }

        public void AddNode(int value)
        {
            AddSubling(value, ref Root);
            
            if (value > 0)
                counterPlus++;
            else if (value < 0)
                counterMinus++;
            else isZero = true;
        }

        public void DisplayTree()
        {
            DisplayNode( Root, "", false);
        }
        
        private void AddSubling(int value, ref Node localRoot)
        {
            if (localRoot == null)
            {
                localRoot = new Node(value);
            }
            else if (value.CompareTo(localRoot.Value) >= 0)
            {
                if (localRoot.Left != null)
                    AddSubling(value, ref localRoot.Left);
                else
                {
                    localRoot.Left = new Node(value);
                }
            }
            else if (value.CompareTo(localRoot.Value) < 0)
            {
                if (localRoot.Right != null)
                    AddSubling(value, ref localRoot.Right);
                else
                {
                    localRoot.Right = new Node(value);
                }
            }
        }
       
        private void DisplayNode(Node localRoot, string prefix, bool isLeft)
        {
            if (localRoot != null) {
                Console.Write(prefix);
                Console.Write(isLeft ? "├──": "└──");
                Console.WriteLine($"({localRoot.Value})");

                DisplayNode(localRoot.Left, prefix+(isLeft ? "│   ": "    "), true);
                DisplayNode(localRoot.Right, prefix+(isLeft ? "│   ": "    "), false);
            }
        }
    }
}