using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverrideToString
{
    public class Person
    {
        public string FirstName;

        public string LastName;
        
        public int Age;

        public int number;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(int num)
        {
            this.number = num;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + ", Age :" + Age.ToString();
        }
    }
}
