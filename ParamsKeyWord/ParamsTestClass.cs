using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParamsKeyWord
{
    public class ParamsTestClass
    {
        public void TestMethod1(params int[] items)
        {
            foreach (int item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void TestMethod2(params string[] items)
        {
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
