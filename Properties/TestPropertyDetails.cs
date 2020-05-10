using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Properties
{
    public class TestPropertyDetails
    {
        private List<TestPropertiesClass> testPropertiesCollection;

        public IEnumerable<TestPropertiesClass> TestPropertiesCollection
        {
            get
            {
                return testPropertiesCollection;
            }
        }

        public void AddTestProperty(TestPropertiesClass testProperty)
        {
            if (testProperty == null)
            {
                return;
            }

            if (this.testPropertiesCollection.Contains(testProperty))
            {
                return;
            }
            
            //Add some additional logic here
            this.testPropertiesCollection.Add(testProperty);
        }

        public void RemoveTestProperty(TestPropertiesClass testProperty)
        {
            //add some logic here
            this.testPropertiesCollection.Remove(testProperty);
        }
    }
}
