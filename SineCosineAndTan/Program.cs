using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SineCosineAndTan
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;
            double A = Math.Tan(a / b);
            double val = Math.Atan(A);
            TimeSpan ts = TimeSpan.FromMilliseconds(5862715);
            Console.Read();
        }
    }
}
