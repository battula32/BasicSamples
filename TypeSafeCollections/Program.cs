using System;
using System.Collections.Generic;
using System.Text;

namespace TypeSafeCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Custom collecctions");

            PersonCollection personCollection = new PersonCollection();
            personCollection.Add(new Person("Ravi", 30));
            personCollection.Add(new Person("Sai", 28));
            personCollection.Add(new Person("Nikhil", 0));

            Console.WriteLine("Size of custom collection is {0}", personCollection.Count);
            Person person = personCollection.Get(2);
            Console.WriteLine(person.ToString());
            Console.WriteLine();

            foreach (Person p in personCollection)
            {
                Console.WriteLine(p.ToString());
            }

            Console.Read();
        }
    }
}
