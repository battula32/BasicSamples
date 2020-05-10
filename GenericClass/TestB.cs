using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericClass
{
    public class TestB<T> where T:TestA
    {
        public T GetSomethingFromTestB(T lMyValue)
        {
            return lMyValue;
        }
    }
}
