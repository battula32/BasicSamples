using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParamsKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsTestClass obj = new ParamsTestClass();
            obj.TestMethod1(10, 20, 30, 40);
            obj.TestMethod2("Hello", "Ravi", "Battula");
            obj.TestMethod1(10000);
            obj.TestMethod2("Hello");

            Console.Read();
        }
    }
}
