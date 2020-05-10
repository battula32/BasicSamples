using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisposeObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            (testClass as IDisposable).Dispose();
            Console.Read();
        }
    }
}
