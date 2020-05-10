using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShallowCopyAndDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create instance of Person
            Person p1 = new Person();
            p1.Age = 30;
            p1.Name = "Ravi";
            p1.IdInfo = new IdInfo(1000);

            //Shallow copy
            Person p2 = p1.ShallowCopy();

            //Display values of p1 and p2
            Console.WriteLine();
            Console.WriteLine("Origional value of p1 and p2");

            Console.WriteLine();
            Console.WriteLine("p1 instance values");
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p1.Name, p1.Age);
            Console.WriteLine("      Value: {0:d}", p1.IdInfo.IdNumber);

            Console.WriteLine();
            Console.WriteLine("p2 instance values");
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p2.Name, p2.Age);
            Console.WriteLine("      Value: {0:d}", p2.IdInfo.IdNumber);

            //Change value of p1 properties and display the values of p1 and p2
            Console.WriteLine();
            Console.WriteLine("Changing value of p1 properties and display the values of p1 and p2 .....");
            p1.Age = 33;
            p1.Name = "Vasu";
            p1.IdInfo.IdNumber = 2000;
            Console.WriteLine("\n values of p1 and p2 after changes to p1:");
            Console.WriteLine("\n p1 instance values: ");
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p1.Name, p1.Age);
            Console.WriteLine("      Value: {0:d}", p1.IdInfo.IdNumber);

            Console.WriteLine("\n p2 instance values: ");
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p2.Name, p2.Age);
            Console.WriteLine("      Value: {0:d}", p2.IdInfo.IdNumber);
            //// For your surprise p2.IdInfo is 2000. Why? because if the type is of referece type, then shallow copy create a new type which refers to old referece.

            //////Make a deep copy of p1 and assign to p3
            Console.WriteLine("\nMake a deep copy of p1 and assign to p3....");
            Person p3 = p1.DeepCopy();
            p1.Name = "Sai";
            p1.Age = 28;
            p1.IdInfo.IdNumber = 3000;
            Console.WriteLine("\n Values of p1 and p3 after changes to p1: ");
            Console.WriteLine("\n p1 instance values: ");
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p1.Name, p1.Age);
            Console.WriteLine("      Value: {0:d}", p1.IdInfo.IdNumber);

            Console.WriteLine("\n p3 instance values: ");
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p3.Name, p3.Age);
            Console.WriteLine("      Value: {0:d}", p3.IdInfo.IdNumber);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter<> to close");
            Console.Read();
        }
    }
}
