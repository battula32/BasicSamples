using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAndEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestForEnumsCodeBreaking testForEnumsCodeBreaking = new TestForEnumCodeBreaking();
            testForEnumsCodeBreaking.Method1();

            Console.Read();
        }
    }
}
