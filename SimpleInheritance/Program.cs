using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SubClass subClass = new SubClass() { Name = "Nikhil", Age = 2 };
            Console.WriteLine("Name : {0}, Age : {1}", subClass.Name, subClass.Age);
            Console.Read();
        }
    }
}
