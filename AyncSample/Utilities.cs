using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AyncSample
{
    public class Utilities
    {
        public delegate double DelegateAdd(double arg1, double arg2);

        public double Add(double arg1, double arg2)
        {
            System.Threading.Thread.Sleep(5000);
            return arg1 + arg2;
        }
    }
}
