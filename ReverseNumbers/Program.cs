using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 456;
            var temp = a.ToString().ToCharArray().Reverse();
            int b = Convert.ToInt32(new string(temp.ToArray()));
            Console.WriteLine(b);
            Console.Read();
        }
    }
}
