using System;

namespace MulticastDelegate
{
    internal delegate void MyDelegate(string s);

    static class Program
    {
        static void Main(string[] args)
        {
            MyDelegate singleDelegate1 = MyMethod1;
            MyDelegate singleDelegate2 = MyMethod2;
            MyDelegate multiDelegate1 = singleDelegate1 + singleDelegate2;
            MyDelegate multiDelegate2 = multiDelegate1 - singleDelegate2;

            Console.WriteLine("Single delegate 1 is called");
            singleDelegate1("Hello Ravi");

            Console.WriteLine("Single delegate 2 is called");
            singleDelegate2("Hi Ravi");

            Console.WriteLine("Multi delegate 1 is called");
            multiDelegate1("Ravi");

            Console.WriteLine("Multi delegate 2 is called");
            multiDelegate2("Battula");

            Console.Read();
        }

        static void MyMethod1(string method1Param)
        {
            Console.WriteLine("Method 1 is called and argument passed is => {0}", method1Param);
        }

        static void MyMethod2(string method2Param)
        {
            Console.WriteLine("Method 2 is called and argument passed is => {0}", method2Param);
        }
    }
}
