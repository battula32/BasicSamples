using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            OuterClass.InnerClass ic = new OuterClass.InnerClass();
            ic.InnerClassMetod();
            Console.Read();
        }
    }
}
