using System;
using System.Collections.Generic;
using System.Text;

//Form Venkat S.
namespace LoanPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using(SampleClass sampleClass = new SampleClass())
            {
                sampleClass.Operation1();
                sampleClass.Operation2();
            }

            Console.Read();
        }
    }

    internal class SampleClass :IDisposable
    {
        public SampleClass()
        {
            Console.WriteLine("Sample class constructed");
        }
        public void Operation1()
        {
            Console.WriteLine("Operation 1");
        }

        public void Operation2()
        {
            Console.WriteLine("Operation 2");
        }

        #region IDisposable Members

        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }

        private static void Close()
        {
            Console.WriteLine("Sample class disposed");
        }

        #endregion
    }
}
