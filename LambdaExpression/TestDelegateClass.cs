using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpression
{
    public class TestDelegateClass
    {
        public delegate TOutput GenericDelegate<TInput, TOutput>(TInput l); 
        public delegate int TestDelegate(int l);
        public int TestMethod(int l)
        {
            return l * 2;
        }

        public double TestMethod1(double l)
        {
            return l * 2;
        }

        public string TestMethod2(string str)
        {
            return "Hello " + str;
        }
    }
}
