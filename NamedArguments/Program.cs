using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedArguments namedArguments = new NamedArguments();
            namedArguments.Method(b: 10, a: 20);
            
            Console.Read();
        }
    }
}
