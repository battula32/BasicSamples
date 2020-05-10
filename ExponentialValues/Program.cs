using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExponentialValues
{
    class Program
    {
        static void Main(string[] args)
        {
            double prevValue = 100.0d;
            double prevVariable = 36;
            for (int i = 0; i <= 70; i++)
            {
                //Console.Write(Math.Pow(2, -i)*1000000000);
                //Console.Write("     ");
                //Console.Write(Math.Exp(i));
                //Console.WriteLine();
                double newVariable = prevVariable - i / 70.0;
                double currentValue = prevValue - newVariable;
                Console.WriteLine("{2}. CurrentValue = {0}, Diff with PrevValue ={1}", currentValue, prevValue - currentValue, i+1);

                //prevValue = currentValue;
                prevVariable = newVariable;
            }

            Console.Read();
        }
    }
}
