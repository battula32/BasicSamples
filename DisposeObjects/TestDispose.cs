using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace DisposeObjects
{
    public class TestDispose : IDisposable
    {
        private bool isDisposed = false;
        Button button;
        public TestDispose()
        {
            button = new Button();
            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(button));

            // Determine the best available approximation of the number 
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

            // Perform a collection of generation 0 only.
            GC.Collect(0);

            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(button));

            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

            // Perform a collection of generation 2 only.
            GC.Collect(2);

            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(button));
            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
        }

        protected void Dispose(bool disposing)
        {
            if (!this.isDisposed)
            {
                if (disposing)
                {
                    button.Dispose();
                }

                Console.WriteLine("After didposing .....");
                // Determine which generation myGCCol object is stored in.
                Console.WriteLine("Generation: {0}", GC.GetGeneration(button));

                // Determine the best available approximation of the number 
                // of bytes currently allocated in managed memory.
                Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

                // Perform a collection of generation 0 only.
                GC.Collect(0);

                // Determine which generation myGCCol object is stored in.
                Console.WriteLine("Generation: {0}", GC.GetGeneration(button));

                Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

                // Perform a collection of generation 2 only.
                GC.Collect(2);

                // Determine which generation myGCCol object is stored in.
                Console.WriteLine("Generation: {0}", GC.GetGeneration(button));
                Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
                this.isDisposed = true;
            }
        }

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            Dispose(!this.isDisposed);
            this.isDisposed = true;
        }

        #endregion
    }
}
