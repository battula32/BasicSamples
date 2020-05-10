using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace BitArrayNS
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes = BitConverter.GetBytes(65);

            // initialize bit arrays
            BitArray myBA1 = new BitArray(5);

            BitArray myBA2 = new BitArray(5, false);
            
            byte[] myBytes = new byte[5] { 1, 2, 3, 4, 5 };
            BitArray myBA3 = new BitArray(myBytes);

            bool[] myBools = new bool[5] { true, false, true, false, false };
            BitArray myBA4 = new BitArray(myBools);

            int[] myInts = new int[5] { 6<<28, 7<<32, 8, 9, 10 };
            BitArray myBA5 = new BitArray(myInts);

            // Displays the properties and values of the bitarrays.
            Console.WriteLine("myBA1");
            Console.WriteLine(" count:  {0}", myBA1.Count);
            Console.WriteLine(" Length: {0}", myBA1.Length);
            PrintValues(myBA1, 8);

            Console.WriteLine("\nmyBA2");
            Console.WriteLine(" count:  {0}", myBA2.Count);
            Console.WriteLine(" Length: {0}", myBA2.Length);
            PrintValues(myBA2, 8);

            Console.WriteLine("\nmyBA3");
            Console.WriteLine(" count:  {0}", myBA3.Count);
            Console.WriteLine(" Length: {0}", myBA3.Length);
            PrintValues(myBA3, 8);

            Console.WriteLine("\nmyBA4");
            Console.WriteLine(" count:  {0}", myBA4.Count);
            Console.WriteLine(" Length: {0}", myBA4.Length);
            PrintValues(myBA4, 8);

            Console.WriteLine("\nmyBA5");
            Console.WriteLine(" count:  {0}", myBA5.Count);
            Console.WriteLine(" Length: {0}", myBA5.Length);
            PrintValues(myBA5, 8);

            Console.Read();
        }

        public static void PrintValues(IEnumerable myList, int myWidth)
        {
            int i = myWidth;
            foreach (Object obj in myList)
            {
                if (i <= 0)
                {
                    i = myWidth;
                    Console.WriteLine();
                }
                i--;
                Console.Write("{0,8}", obj);
            }
            Console.WriteLine();
        }
    }
}
