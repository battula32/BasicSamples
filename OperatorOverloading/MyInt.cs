using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverloading
{
    public class MyInt
    {
        private object item;

        public MyInt(object item)
        {
            this.item = item;
        }

        public static MyInt operator +(MyInt param1, MyInt param2)
        {
            int p1 = Convert.ToInt32(param1.item);
            int p2 = Convert.ToInt32(param2.item);
            MyInt result = new MyInt(p1+p2);
            return result;
        }
    }
}
