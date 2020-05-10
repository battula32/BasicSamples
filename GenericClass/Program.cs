using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TestA a = new TestA();
            var testB = new TestB<TestA>();
            var testGeneric = new TestGeneric<IList<TestA>, TestA>();

            Console.Read();
        }
    }
}
