using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalizeAndDispose
{
    public class TestClass
    {
        public TestClass()
        {
            Console.WriteLine("Called TestClass constructor");
        }

        ~TestClass()
        {
            Console.WriteLine("Called TestClass Destructor");
        }
    }
}
