using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoStateObject
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                MonoStateClass obj = new MonoStateClass();
                Console.WriteLine(obj.Variable);
                Console.WriteLine("Hash of the object is {0} ", obj.GetHashCode()); // For each object hash code is different
            }

            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.Val);
            Console.Read();
        }
    }

    class MyClass
    {
        public static int val = 10;

        public int Val
        {
            get
            {
                return val;
            }
        }

        static MyClass()
        {
            val = 100;
        }
    }
}
