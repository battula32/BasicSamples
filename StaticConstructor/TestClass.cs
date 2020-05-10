using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticConstructor
{
    public class TestClass
    {
        private static int testMember = 20;

        static TestClass()
        {
            testMember = 10;
        }

        public static int TestMemeber
        {
            get
            {
                return testMember;
            }

            set
            {
                testMember = value;
            }
        }
    }
}
