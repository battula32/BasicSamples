using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicClassProperties
{
    public class TestBaseClass
    {
        private const double PI = 3.14;
        public TestBaseClass()
        {
            Console.WriteLine("base constructor is called");
        }

        public virtual double Area(double  radious)
        {
            Console.WriteLine("Area of circle");
            return PI * radious * radious;
        }

        public void Display()
        {
            Console.WriteLine("This is base display");
        }
    }

    public class DerivedCalss : TestBaseClass
    {
        private const double PI = 3.14;

        public DerivedCalss(): base()
        {
            Console.WriteLine("derived constructor is called");
        }

        public override double Area(double radious)
        {
            Console.WriteLine("Area of spear");
            return PI * radious * radious * radious;
        }

        public void Display()
        {
            Console.WriteLine("This is Derived display");
        }
    }
}
