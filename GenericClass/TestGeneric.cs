using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericClass
{
    public class TestGeneric<T,U> where T:IList<U>
    {
        public T GetData(IList<U> uList)
        {
            return (T)uList;
        }
    }
}
