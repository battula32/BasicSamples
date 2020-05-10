using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            TuplesUsage tupleUsage = new TuplesUsage();
            tupleUsage.UsageofTuple();
            tupleUsage.UsageofTuple1();
            Console.WriteLine("Item 1 = {0}, Item 2 = {1}", tupleUsage.TupleProperty.Item1, tupleUsage.TupleProperty.Item2);
            tupleUsage.UpdateTupleProperty("Hello Ravi", 2);
            Console.WriteLine("Item 1 = {0}, Item 2 = {1}", tupleUsage.TupleProperty.Item1, tupleUsage.TupleProperty.Item2);

            Console.Read();
        }
    }
}
