using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YieldKeyword
{
    public class Fibonacci
    {
        public static IEnumerable<int> GetFebSeries(int fibCount)
        {
            for (int count = 0, prevFib =1, curFib =1; count < fibCount; count++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
        }
    }
}
