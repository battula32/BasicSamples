using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodHiding
{
    public class Animal
    {
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof");
        }

        public virtual void BigBark()
        {
            Console.WriteLine("Big woof ...");
        }
    }

    public class Chihuhua : Dog
    {
        public new void Bark() //// If you remove new compiler give warning, If you add new compiler understand that you know method hiding
        {
            Console.WriteLine("Yip");
        }

        public override void BigBark()
        {
            Console.WriteLine("Big Yip");
        }
    }
}
