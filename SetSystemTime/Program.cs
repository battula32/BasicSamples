using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetSystemTime
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemTime st = new SystemTime();
            st.SetSystemTime(new DateTime(2011, 01, 20, 15, 30, 30));
        }
    }
}
