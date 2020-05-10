using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Management.Instrumentation;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Square s1 = new Square(10);
            ////Square s2 = new Square(20);
            ////Square s3 = s1 + s2; // This will call operator + (Square,Square)
            ////Console.WriteLine(s3);
            ////Console.WriteLine(s3 + 15); // This will call operator + (Square,int) and then ToString()
            ////Console.WriteLine(s3 + 1.5);// This will call operator + (Square,double) and then ToString()
            ////s3 = 10; // This will call operator Square(int)
            ////Console.WriteLine(s3);
            ////Square s4 = 10;
            ////Console.WriteLine(s1 == s4); //Calls == operator
            ////Console.WriteLine(s1 != s4); //Calls != operator
            ////Console.WriteLine(s1 > s2); //Calls > operator
            ////Console.WriteLine(s1 <= s4); //Calls <= operator

            //OperatorOverloadedClass op1 = new OperatorOverloadedClass();
            //op1.Point = new Point(10, 20);

            //OperatorOverloadedClass op2 = new OperatorOverloadedClass();
            //op2.Point = new Point(30, 40);
            //OperatorOverloadedClass op3 = new OperatorOverloadedClass();
            //op3 = op1 + op2;
            //Console.WriteLine("the overloaded result is {0}, {1}", op3.Point.X, op3.Point.Y);
            //Console.Read();

            MyInt myItem1 = new MyInt(10);
            MyInt myItem2 = new MyInt(20);
            MyInt result = myItem1 + myItem2;

            Console.WriteLine(result.ToString());
            

            MyCustomInt myCustomInt = new MyCustomInt();
            Console.WriteLine(myCustomInt.ToString());

            Console.Read();
        }
    }
}
