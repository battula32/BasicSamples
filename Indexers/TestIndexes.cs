using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexers
{
    class TestIndexers
    {
        private string[] testString = "Hello this is Ravi Battula".Split();

        public string this[int wordNumber]
        {
            get
            {
                if (this.testString.Count() > wordNumber)
                {
                    return this.testString[wordNumber];
                }
                else
                {
                    return string.Empty;
                }
            }

            set
            {
                if (this.testString.Count() > wordNumber)
                {
                    testString[wordNumber] = value;
                }
            }
        }

        public string this[int param1, int param2] // indexers can take more than one parameter.
        {
            get
            {
                if (this.testString.Count() > param1 && this.testString.Count() > param2)
                {
                    return this.testString[param1] + " " + this.testString[param2];
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
