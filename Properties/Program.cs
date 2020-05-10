using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TestPropertiesClass testproperties = new TestPropertiesClass();

            testproperties.TestValue1 = 10.23;
            Console.WriteLine("Test value 1 is {0}", testproperties.TestValue1);

            //testproperties.TestValue2 = 20.543; //this give compiler error because private setter is used. this can be set only from the same class.
            //TestValue2 is read only for ouside, like this we can encapsulate.
            testproperties.SetValueForTestVale2(20.579);
            Console.WriteLine("Test value 2 is {0}", testproperties.TestValue2);

            CollectionEncapsulation();

            Console.Read();
        }

        private static void CollectionEncapsulation()
        {
            TestPropertyDetails testPropertyDetails = new TestPropertyDetails();
            testPropertyDetails.AddTestProperty(null);
            testPropertyDetails.RemoveTestProperty(null);
        }
    }
}
