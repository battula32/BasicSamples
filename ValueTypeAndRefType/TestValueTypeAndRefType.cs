using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueTypeAndRefType
{
    struct TestValueType
    {
        public int X;
        public int Y;
        public TestRefType TestRefType;

        public TestValueType(int x, int y, TestRefType testRefType)
        {
            this.X = x;
            this.Y = y;
            this.TestRefType = testRefType;
        }
    }

    public class TestRefType
    {
        private string refVariable;

        public string RefVariable
        {
            get
            {
                return this.refVariable;
            }

            set
            {
                this.refVariable = value;
            }
        }
    }

    public class TestType
    {
        public void ValueType(int a)
        {
            a = a + 1;
            Console.WriteLine("Value of a in inside method is {0}", a); 
        }

        public void PassingRefTypeByValueCopy(StringBuilder sb)
        {
            sb.Append("Hello"); //this sb and sbRef in Main are refered to same reference location with different variables. Here we are removing the reference connection of sb
            sb = null;
        }

        public void PassbyRef(ref int l)
        {
            l = l + 1;
            Console.WriteLine("Value of l pass by ref {0}", l);
        }

        public void Swap(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }

        public void swapWithouttemp(ref int x, ref int y)//10,20
        {
            x = x - y;
            y = y + x;         // y gets the original value of x   
            x = y - x;    // x gets the original value of y
        }
    }
}
