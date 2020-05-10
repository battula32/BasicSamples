using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueTypeAndRefType
{
    class Program
    {
        static void Main(string[] args)
        {
            TestValueType objValue;
            objValue.X = 10;
            objValue.Y = 20;
            TestRefType testref = new TestRefType();
            testref.RefVariable = "Hello";
            objValue.TestRefType = testref;

            Console.WriteLine("X {0}, Y {1}, ref value {2} ", objValue.X, objValue.Y, objValue.TestRefType.RefVariable);
            TestValueType objValue1 = objValue;

            objValue.X = 20000;
            testref.RefVariable = "Battula";

            
            Console.WriteLine("X {0}, Y {1}, ref value {2} ", objValue1.X, objValue1.Y, objValue1.TestRefType.RefVariable);
            
            TestType testType = new TestType();
            int a = 10;
            testType.ValueType(a);
            Console.WriteLine("Value of a in outside method is {0}", a);

            StringBuilder sbRef = new StringBuilder();
            testType.PassingRefTypeByValueCopy(sbRef);
            Console.WriteLine(sbRef);

            int x = 20;
            testType.PassbyRef(ref x);
            Console.WriteLine("value of x is {0}", x);
            string par1 = "Ravi";
            string par2 = "Hello";

            Console.WriteLine("{0} {1}", par1, par2);
            testType.Swap(ref par1, ref par2);
            Console.WriteLine("{0} {1}", par1, par2);

            x = 10;
            int y = 20;
            Console.WriteLine("x and y are {0}, {1}", x, y);
            testType.swapWithouttemp(ref x, ref y);
            Console.WriteLine("x and y are {0}, {1}", x, y);

            Console.Read();
        }
    }
}
