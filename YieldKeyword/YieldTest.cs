using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YieldKeyword
{
    class YieldTest
    {
        public List<int> GetListWithoutYield(int size)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(i);
            }

            return list;
        }

        public IEnumerable<int> GetListWithYield(int size)
        {
            for (int i = 0; i < size; i++)
            {
                yield return i;
            }
        }
    }
}
