using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

//This is taken from Venkat Subramaniam blog
//  http://blog.agiledeveloper.com/2012/01/collections-of-presentation-videos.html

namespace PlugTheCodeUsingLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = {10, 20, 5, 6, 7};

            GetTotal(prices, (price)=>true); //Total all
            GetTotal(prices, (price) => price % 2 == 0 ); //Total even
            GetTotal(prices, (price) => price % 2 != 0); //Total Odd
            GetTotal(prices, (price) => price > 6); //Total if price > 6

            Console.Read();
        }

        private static void GetTotal(int[] prices, Func<int, bool> isTrue)
        {
            int total = 0;
            foreach (int price in prices)
            {
                if (isTrue(price))
                {
                    total += price;
                }
            }

            Console.WriteLine("Total is {0}", total);
        }
    }
}
