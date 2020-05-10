using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//This concept is taken from Shivprasad koirala
namespace AnonymousTypesAndGenericCast
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Ravi Battula 001";
            var genericObject = Cast(GetAnonymousObject(str), new { FirstName = "", LastName = "", RollNo = 0 });
            Console.WriteLine("FirstName : {0}", genericObject.FirstName);
            Console.WriteLine("LastName : {0}", genericObject.LastName);
            Console.WriteLine("Roll No : {0}", genericObject.RollNo);
            Console.Read();
        }

        static object GetAnonymousObject(string str)
        {
            string[] strArray = str.Split(' ');

            return new { FirstName = strArray[0], LastName = strArray[1], RollNo = int.Parse(strArray[2]) };
        }

        static T Cast<T>(object obj, T type)
        {
            return (T)obj;
        }
    }
}
