using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestedClasses
{
    class OuterClass
    {
        private int y = 10;
        public class InnerClass
        {
            public void InnerClassMetod()
            {
                Console.WriteLine("Hello from Inner class");
                OuterClass oc = new OuterClass();
                Console.WriteLine("Accessing private member of outer class {0}", oc.y);
                //Console.WriteLine("Accessing private member of outer class {0}", y); // can not access
            }
        }
    }
}
