using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAndEnums
{
    public enum TestForCodeBreak { One, Two };
    class TestForEnumCodeBreaking :ITestForEnumsCodeBreaking
    {
        void ITestForEnumsCodeBreaking.Method1()
        {
            Console.WriteLine("From inteface Method1");
        }

        public void Method2()
        {

        }
    }
}
