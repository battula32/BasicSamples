using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dogObj = new Dog();
            dogObj.Bark(); // Woof
            dogObj.BigBark(); //Big Woof

            Dog chihuhua = new Chihuhua();
            chihuhua.Bark(); // Woof .... this is right what you expected this hides derived implementation
            chihuhua.BigBark(); // Big Yip

            Chihuhua chihuhua1 = new Chihuhua();
            chihuhua1.Bark(); // Yip
            chihuhua1.BigBark();// Big Yip

            Console.Read();
        }
    }
}
