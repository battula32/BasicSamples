using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismEx
{
    abstract class AbstractTest
    {
        public abstract int GetValue(int l);

        public abstract string Name { get; protected set; }
    }
}
