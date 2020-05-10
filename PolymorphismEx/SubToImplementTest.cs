using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismEx
{
    class SubToImplementTest :ImplementTest
    {
        private ImplementTest implementTest;
        private string newName;
        private int myDigits;
        public SubToImplementTest()
        {
            this.implementTest = new ImplementTest();
            this.myDigits = 5167;
        }

        public string NewName 
        {
            get
            {
                return this.implementTest.Name;
            }
            set
            {
                this.newName = value;
                this.TestName = value;
            }
        }

        public override string TestName
        {
            get
            {
                return base.TestName;
            }
            protected set
            {
                base.TestName = value;
            }
        }

        public int MyDigits
        {
            get
            {
                return this.myDigits;
            }

            set
            {
                this.myDigits = value;
            }
        }
    }
}
