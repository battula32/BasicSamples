using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyDataClass> myDataList = new List<MyDataClass>();
            MyDataClass myData = new MyDataClass() { Id = 1, Name = "SGV" };
            myDataList.Add(myData);
            myData = new MyDataClass() { Id = 2, Name = "BRB" };
            myDataList.Add(myData);
            myData = new MyDataClass() { Id = 3, Name = "VAAG" };
            myDataList.Add(myData);
            myData = new MyDataClass() { Id = 4, Name = "GVA" };
            myDataList.Add(myData);

            MyGenericClass<MyDataClass> data = new MyGenericClass<MyDataClass>();
            foreach (var item in myDataList)
            {
                data.Write(item);
                Console.WriteLine("data object hash code is {0}",  data.GetHashCode());
            }

            Console.Read();
        }
    }
}
