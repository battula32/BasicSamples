using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionalParameters optionalParameters = new OptionalParameters();
            optionalParameters.Method();
            optionalParameters.Method(30);

            var listTemp = new BindingList<OptionalParameters>();
            listTemp.AddNew();
            Console.WriteLine(listTemp.Count.ToString());
            Console.Read();
        }
    }
}
