using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomeAdvancedStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTestSomeStuffClass obj = new TestTestSomeStuffClass();
            Console.WriteLine(obj.ListOfTestSomeStuff.Count.ToString());
            foreach (TestSomeStuff obj1 in obj.ListOfTestSomeStuff)
            {
                Console.WriteLine("Variables are {0}, {1}, {2}", obj1.SomeBool, obj1.Someint, obj1.SomeString);
            }

            Console.Read();
        }
    }
}
