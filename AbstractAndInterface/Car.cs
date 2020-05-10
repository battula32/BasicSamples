using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractAndInterface
{
    public abstract class Car
    {
        public void TataIndica()
        {
            Console.WriteLine("This is tata indica car");
        }

        public abstract void Maruti();
    }

    public class MarutiCar : Car
    {
        public override void Maruti()
        {
            Console.WriteLine("This is Maruti car");
        }
    }
}
