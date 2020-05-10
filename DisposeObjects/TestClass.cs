using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DisposeObjects
{
    public class TestClass :IDisposable
    {
        private bool isDisposed;
        private TextReader tr;
        public TestClass()
        {
            Console.WriteLine("Test class constructor is called");
            this.tr = File.OpenText("Hello.txt");
            Console.WriteLine(this.tr.ReadToEnd());
            this.tr.Close();
        }

        public void Dispose(bool dispose)
        {
            if(!this.isDisposed)
            {
                if (dispose)
                {
                    //// object.Dispose();
                    this.tr.Dispose();
                    Console.WriteLine("objects externally disposed");
                }

                this.isDisposed = true;
            }
        }

        ~TestClass()
        {
            this.Dispose(false);
            Console.WriteLine("Test class destructor is called"); 
        }

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this.tr);
            //GC.SuppressFinalize(this); // need to mention the object name
            // Since I supressed "this" object, .Net frame work won't call destructor. If you comment supress statement or change supression object, then Frame work calls destructor.
        }

        #endregion
    }
}
