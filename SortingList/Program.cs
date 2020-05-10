using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> details = new List<string>();
            details.Add("xyz");
            details.Add("abc");
            details.Add("pqr");

            Console.WriteLine("Before sort");
            foreach (var list in details)
            {
                Console.WriteLine(list);
            }

            details.Sort();

            Console.WriteLine("After sort");
            foreach (var list in details)
            {
                Console.WriteLine(list);
            }

            Console.Read();
        }
    }
}
