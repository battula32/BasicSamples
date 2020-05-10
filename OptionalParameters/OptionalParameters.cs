using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptionalParameters
{
    class OptionalParameters
    {
        public string Param1
        {
            get;
            private set;
        }

        public string Param2
        {
            get;
            private set;
        }

        public OptionalParameters(string param1 = "", string param2 = "")
        {
        }
        public OptionalParameters()
        {
        }

        public void Method(int x = 20)
        {
            Console.WriteLine("This is optional parameter {0}", x);
        }
    }
}
