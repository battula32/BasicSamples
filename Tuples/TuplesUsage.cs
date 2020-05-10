using System;

namespace Tuples
{
    /// <summary>
    /// Tuples are used for logical grouping of items
    /// </summary>
    public class TuplesUsage
    {
        private Tuple<string, int> tupleProperty;

        Tuple<int, string> SomeTupeDelegate()
        {
            return Tuple.Create(1, "Hello");
        }

        /// <summary>
        /// Usageofs the tuple.
        /// </summary>
        public void UsageofTuple()
        {
            var tupleTest = Tuple.Create<int, int, int, int>(10, 20, 30, 40);
            Console.WriteLine("Item1 {0}", tupleTest.Item1);
            Console.WriteLine("Item2 {0}", tupleTest.Item2);
            Console.WriteLine("Item3 {0}", tupleTest.Item2);
            Console.WriteLine("Item4 {0}", tupleTest.Item3);
            var tupleTest1 = Tuple.Create<string, int, int, int>("TupeTest", 20, 30, 40);
            Console.WriteLine("Item1 {0}", tupleTest1.Item1);
            Console.WriteLine("Item2 {0}", tupleTest1.Item2);
            Console.WriteLine("Item3 {0}", tupleTest1.Item2);
            Console.WriteLine("Item4 {0}", tupleTest1.Item3);
        }

        public void UsageofTuple1()
        {
            var tupleTest = SomeTupeDelegate();
            Console.WriteLine("Using Tuple Delegate method");
            Console.WriteLine("Item 1 {0}", tupleTest.Item1);
            Console.WriteLine("Item 2 {0}", tupleTest.Item2);
        }

        public void UpdateTupleProperty(string item1, int item2)
        {
            this.tupleProperty = Tuple.Create<string, int>(item1, item2);
        }

        public Tuple<string, int> TupleProperty
        {
            get
            {
                if (this.tupleProperty == null)
                {
                    this.tupleProperty = Tuple.Create<string, int>("Hello Battula", 1);
                }

                return this.tupleProperty;
            }
        }
    }
}
