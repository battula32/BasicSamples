using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleInheritance
{
    class BaseClass
    {
        public string Name
        {
            get;
            set;
        }
    }

    class SubClass : BaseClass
    {
        public int Age
        {
            get;
            set;
        }
    }
}
