using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace PredicateDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tmpList= new List<int>{1,2,3,4,5,6};

            Console.WriteLine("Normal List...");
            foreach (int l in tmpList)
            {
                Console.WriteLine("{0}", l);
            }

            Predicate<int> predList = new Predicate<int>(GetListGreaterThan3); // This is filter strategy
            List<int> filteredList = tmpList.FindAll(predList);
            Console.WriteLine("Filtered List...");
            foreach (int l in filteredList)
            {
                Console.WriteLine("{0}", l);
            }

            //filter with inline delegate
            filteredList = tmpList.FindAll(delegate(int i)
                                            {
                                                return i > 3;
                                            });

            Console.WriteLine("Filter with inline delegate...");
            foreach (int l in filteredList)
            {
                Console.WriteLine("{0}", l);
            }

            // inline code i.e lambda expression
            Console.WriteLine("Filter with inline code");
            filteredList = tmpList.FindAll(i => i > 3);

            foreach (int l in filteredList)
            {
                Console.WriteLine("{0}", l);
            }

            List<TempData> tempDataList = new List<TempData>();

            TempData tempData = new TempData() { Number1 = 1, Str1 = "Hello 1", Str2 = "Ravi 1" };
            tempDataList.Add(tempData);

            tempData = new TempData() { Number1 = 2, Str1 = "Hello 2", Str2 = "Ravi 2" };
            tempDataList.Add(tempData);

            tempData = new TempData() { Number1 = 3, Str1 = "Hello 3", Str2 = "Ravi 3" };
            tempDataList.Add(tempData);

            tempData = new TempData() { Number1 = 4, Str1 = "Hello 4", Str2 = "Ravi 4" };
            tempDataList.Add(tempData);

            tempData = new TempData() { Number1 = 5, Str1 = "Hello Battula", Str2 = " Raveendrababu" };

            var data = tempDataList.Find(delegate(TempData tmp)
            {
                return tmp.Number1 == tempData.Number1;
            });

            //var data = tempDataList.Find(FindMatch);

            if (data != null)
            {
                data = tempData;
            }

            Console.Read();
        }

        public static bool GetListGreaterThan3(int arg)
        {
            return arg > 3;
        }

        public static bool FindMatch(TempData tempData)
        {
            return tempData.Number1 == 5;
        }
    }


    class TempData
    {
        string str1;

        public string Str1
        {
            get { return str1; }
            set { str1 = value; }
        }

        string str2;

        public string Str2
        {
            get { return str2; }
            set { str2 = value; }
        }

        int number1;

        public int Number1
        {
            get { return number1; }
            set { number1 = value; }
        }
    }

}
