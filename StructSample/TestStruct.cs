using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructSample
{
    public struct TestStruct
    {
        public int x=1, y=1;
        //public TestStruct()// This is illegal
        //{
        //}

        public TestStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
