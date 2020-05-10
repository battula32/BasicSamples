using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructionClasses.Generics
{
    class GenCompare<T> where T:IComparable
    {
        public T t1;
        public T t2;

        public GenCompare(T _t1, T _t2)
        {
            this.t1 = _t1;
            this.t2 = _t2;
        }

        public T Max()
        {
            if (this.t2.CompareTo(t1) < 0)
            {
                return t1;
            }
            else
            {
                return t2;
            }
        }
    }
}
