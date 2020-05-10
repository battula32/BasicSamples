using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructionClasses.Generics
{
    class Normal
    {
        public object t;
        public object u;

        public Normal(object _t, object _u)
        {
            this.t = _t;
            this.u = _u;
        }
    }

    class Generic<T, U>
    {
        public T t;
        public U u;
        
        public Generic(T _t, U _u)
        {
            this.t = _t;
            this.u = _u;
        }
    }

    class GenericOther<A, B, C>
    {
        public A Obj1;

        public B Obj2;

        public C Obj3;

        public GenericOther(A obj1, B obj2, C obj3)
        {
            this.Obj1 = obj1;
            this.Obj2 = obj2;
            this.Obj3 = obj3;
        }
    }
}
