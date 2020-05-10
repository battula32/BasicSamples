using System;
using System.Collections.Generic;
using System.Text;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Count; i++)
            {
                //some business logic
                Console.WriteLine(numbers[i]);
                numbers[i] = 20;
            }

            foreach (var i in numbers)
            {
                i = 20; // compiler error
                Console.WriteLine(i);
            }

            numbers.ForEach(i=>Console.WriteLine(i));
            //numbers.FindAll(i => i % 2 == 0).ForEach(i => Console.WriteLine(i));

            Console.Read();
        }
    }
}
