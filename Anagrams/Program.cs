using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Silent";
            string str2 = "Listen";
            var char1 = str1.ToLower().ToCharArray();
            var char2 = str2.ToLower().ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            string newStr1 = new string(char1);
            string newStr2 = new string(char2);
            if(newStr1.Equals(newStr2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Anagrams");
            }
            else
            {
                Console.WriteLine("Not Anagrams");
            }

            Console.Read();
        }
    }
}
