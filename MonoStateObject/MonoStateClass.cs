using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoStateObject
{
    public class MonoStateClass
    {
        private static int variable = 0;

        static MonoStateClass() // Static constructor is called only once
        {
            Random rand = new Random();
            variable = rand.Next();
        }

        public int Variable
        {
            get
            {
                return variable;
            }
        }
    }
}
