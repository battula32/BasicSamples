using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructSample
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStruct testStruct = new TestStruct();
            Console.WriteLine("testStruct.X, testStruct.Y are {0}, {1},  ", testStruct.x, testStruct.y);
            TestStruct testStruct1 = new TestStruct(10, 20);
            Console.WriteLine("testStruct1.X, testStruct1.Y are {0}, {1},  ", testStruct1.x, testStruct1.y);
            Console.Read();
        }
    }
}
