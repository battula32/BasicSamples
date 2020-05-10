using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0.1f;
            float b = 1f;
            float c = 10f;
            Console.WriteLine("Value of a is {0}", a);
            Console.WriteLine("Value of b is {0}", b);
            Console.WriteLine("Value of  b - a*c is {0}", b-a*c);

            decimal x = 1M / 6M;
            double y = 1.0/6.0;
            Console.WriteLine("Value of x is {0}", x);
            Console.WriteLine("Value of y is {0}", y);
            Console.WriteLine("Value of x+x+x+x+x+x is {0}", x + x + x + x + x + x);
            Console.WriteLine("Value of y+y+y+y+y+y is {0}", y + y + y + y + y + y);
            Console.Read();
        }
    }
}
