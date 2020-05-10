using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadOnlyAndConst
{
    class TestClass
    {
        public const int TestConst = 10;// this is implicit static,also initialized at compile time
        public readonly int TestReadonly = 10;
        
        //public const long TestConstant = DateTime.Now.Ticks;// This gives comiper error, because you can not have 
                                                              // DateTime.Now.Ticks at compiler time

        public static readonly long TestStaticReadOnly = DateTime.Now.Ticks;

        public TestClass(int readonlyvalue)
        {
            this.TestReadonly = readonlyvalue;
        }
    }
}
