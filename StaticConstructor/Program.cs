using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestClass testClass = new TestClass();
            Console.WriteLine(TestClass.TestMemeber.ToString());

            for (int i = 0; i < 10; i++)
            {
                TestClass2 testClass2 = new TestClass2();
            }

            Console.WriteLine("Test calss item 2 is {0}", TestClass2.item);

            Console.Read();
        }
    }
}
