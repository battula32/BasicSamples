using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticConstructor
{
    class TestClass2
    {
        public static int item = 10;
        static TestClass2()
        {
            Console.WriteLine("item is {0} ", item);
            item++;
        }
    }
}
