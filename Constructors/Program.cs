using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(350000M);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(car.price);
            car = new Car(450000M, 2012);
            Console.WriteLine(car.price);
            Console.WriteLine(car.year);
            car = new Car(460000M, 2011,"Maruthi");
            Console.WriteLine(car.price);
            Console.WriteLine(car.year);
            Console.WriteLine(car.make);
            Console.Read();
        }
    }
}
