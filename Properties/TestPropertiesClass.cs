using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Properties
{
    public class TestPropertiesClass
    {
        private double testValue1;
        private double testValue2;

        public double TestValue1
        {
            get
            {
                return this.testValue1;
            }

            set
            {
                this.testValue1 = value;
            }
        }

        public double TestValue2
        {
            get
            {
                return Math.Round(this.testValue2, 2);
            }

            private set
            {
                this.testValue2 = value;
            }
        }

        public void SetValueForTestVale2(double testValue)
        {
            this.TestValue2 = testValue;
        }
    }
}
