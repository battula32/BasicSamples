using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructors
{
    public class Car
    {
        public decimal price;
        public int year;
        public string make;

        public Car(decimal price)
        {
            this.price = price;
        }

        public Car(decimal price, int year)
            : this(price)
        {
            this.year = year;
        }

        public Car(decimal price, int year, string make)
            : this(price, year)
        {
            this.make = make;
        }
    }
}
