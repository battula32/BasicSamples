﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TypeSafeCollections
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("Name : {0}, Age : {1}", this.Name, this.Age);
        }
    }
}
