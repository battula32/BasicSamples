using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YieldKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int fib in Fibonacci.GetFebSeries(10))
            {
                Console.Write(fib + "  ");
            }

            Console.WriteLine();
            YieldTest yieldTest = new YieldTest();
            Console.WriteLine("With out Yield");
            foreach (int i in yieldTest.GetListWithoutYield(10))
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("With Yield");
            foreach (int i in yieldTest.GetListWithYield(10))
            {
                Console.Write(i + " ");
            }

            Console.Read();
        }
    }
}
