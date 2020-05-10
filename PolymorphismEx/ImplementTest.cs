using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismEx
{
    class ImplementTest: AbstractTest
    {
        string name;
        string testName;
        public override int GetValue(int l)
        {
            return 10;
        }

        public override string Name
        {
            get
            {
                return "Hello from implenet test";
            }

            protected set
            {
                this.name = value;
            }
        }

        public virtual string TestName 
        {
            get
            {
                return this.testName;
            }
            protected set
            {
                this.testName = value;
            }
        }
    }
}
