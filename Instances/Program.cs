using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Instances
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CreateInstance("Book", new Dictionary<string, object>()
            {
                {"Title", "Who Moved my Cheese"}, 
                {"Pages",47}
            }));

            Console.Read();
        }

        private static object CreateInstance(string className, Dictionary<string, object> values)
        {
            Type type = Type.GetType(className);
            

            object instance = Activator.CreateInstance(type);
            foreach (var entry in values)
            {
                type.GetProperty(entry.Key).SetValue(instance, entry.Value, null);
            }
            
            return instance;
        }
    }

    public class Book
    {
        public string Title { get; set; }

        public int Pages { get; set; }

        public override string ToString()
        {
            return string.Format("Book {0} {1}", Title, Pages);
        }
    }
}
