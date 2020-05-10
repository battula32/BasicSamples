using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicClassProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedCalss derivedObject = new DerivedCalss();
            double area = derivedObject.Area(10);
            Console.WriteLine("Area of spear<from derived Class> is = " + area.ToString());
            derivedObject.Display();

            TestBaseClass testBaseClassObj = new TestBaseClass();
            area = testBaseClassObj.Area(10);

            Console.WriteLine("Area of circle<from base Class> is = " + area.ToString());
            Console.Read();
        }
    }
}
