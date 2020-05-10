using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomeAdvancedStuff
{
    public class TestTestSomeStuffClass
    {
        private IList<TestSomeStuff> listOfTestSomeStuff;

        public TestTestSomeStuffClass()
        {
            this.listOfTestSomeStuff = new List<TestSomeStuff>();
            TestSomeStuff obj = new TestSomeStuff();
            obj.SomeBool = false;
            obj.Someint = 1;
            obj.SomeString = "Hello1";
            this.listOfTestSomeStuff.Add(obj);
            obj = new TestSomeStuff();
            obj.SomeBool = true;
            obj.Someint =2;
            obj.SomeString = "Hello2";
            this.listOfTestSomeStuff.Add(obj);
            obj = new TestSomeStuff();
            obj.SomeBool = true;
            obj.Someint = 3;
            obj.SomeString = "Hello3";
            this.listOfTestSomeStuff.Add(obj);
            obj = new TestSomeStuff();
            obj.SomeBool = true;
            obj.Someint = 4;
            obj.SomeString = "Hello4";
            this.listOfTestSomeStuff.Add(obj);
        }

        public IList<TestSomeStuff> ListOfTestSomeStuff
        {
            get
            {
                return(
                    from var in this.listOfTestSomeStuff where var.SomeBool == true
                    select new TestSomeStuff
                    {
                        SomeString =var.SomeString,
                        Someint =var.Someint,
                        SomeBool = var.SomeBool,
                    }).ToList<TestSomeStuff>();
            }
        }
    }
}
