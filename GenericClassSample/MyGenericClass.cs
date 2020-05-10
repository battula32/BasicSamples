using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericClassSample
{
    public class MyGenericClass<T> where T: MyDataClass
    {
        public void Write(T t)
        {
            Console.WriteLine("Id : {0}, Name : {1}", t.Id, t.Name);
        }
    }
}
