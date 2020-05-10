using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingAndUnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = string.Format("I am using boxing and unboxing to convert this number {0}", 10);
            Console.WriteLine(myString);

            {
                //How this works ! will you code like this
                object thisNumber = 10; // initialization
                object copy = thisNumber; //copies the origional number
                int unBox = (int)copy;
                string usage = unBox.ToString(); // this is will be used as internal substitute

                myString = "I am using boxing and unboxing to convert this number " + usage; // Finally this is the result
                Console.WriteLine(myString); // this is your result

            }

            {
                //How to avoid the above compiler and CLR behavior, simply do this.
                myString = string.Format("I am not using boxing and unboxing to convert this number {0}", 10.ToString());
                Console.WriteLine(myString);
            }

            // same thing happens here also
            Console.WriteLine("I am using boxing and unboxing to convert this number {0}", 10);

            Console.Read();
        }
    }
}
