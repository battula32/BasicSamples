using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            TestIndexers testIndexers = new TestIndexers();
            Console.WriteLine(testIndexers[3]);
            Console.WriteLine(testIndexers[10]);

            Console.WriteLine(testIndexers[3, 4]);

            testIndexers[3] = "Hi";
            Console.WriteLine(testIndexers[3]);
            testIndexers[10] = "Hi";
            Console.WriteLine(testIndexers[10]);
            Console.Read();
        }
    }
}
