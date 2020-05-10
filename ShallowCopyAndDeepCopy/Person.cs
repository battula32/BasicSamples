using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShallowCopyAndDeepCopy
{
    public class Person
    {
        public int Age;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person other = (Person)this.MemberwiseClone();
            other.IdInfo = new IdInfo(this.IdInfo.IdNumber);
            return other;
        }
    }
}
