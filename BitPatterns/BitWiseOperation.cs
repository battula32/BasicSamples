using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitPatterns
{
    public class BitWiseOperation
    {
        // Demonstrate XOR for two integers.
        public void DoXor()
        {
            int a = 5550 ^ 800;
            Console.WriteLine(this.GetIntBinaryString(5550));
            Console.WriteLine(this.GetIntBinaryString(800));
            Console.WriteLine(this.GetIntBinaryString(a));
            Console.WriteLine();

            // Repeat.
            int b = 100 ^ 33;
            Console.WriteLine(this.GetIntBinaryString(100));
            Console.WriteLine(this.GetIntBinaryString(33));
            Console.WriteLine(this.GetIntBinaryString(b));
            Console.WriteLine();

            int c = 100 & 33;
            Console.WriteLine(this.GetIntBinaryString(100));
            Console.WriteLine(this.GetIntBinaryString(33));
            Console.WriteLine(this.GetIntBinaryString(c));
        }

        public void Tilde()
        {
            int a = ~1;
            Console.WriteLine(this.GetIntBinaryString(1));
            Console.WriteLine(this.GetIntBinaryString(a));
        }

        public void LeftShift()
        {
            int a = 1 << 3;
            Console.WriteLine(this.GetIntBinaryString(1));
            Console.WriteLine(this.GetIntBinaryString(a));
        }

        public void RightShift()
        {
            int a = 1 >> 3;
            Console.WriteLine(this.GetIntBinaryString(1));
            Console.WriteLine(this.GetIntBinaryString(a));
        }

        /// <summary>
        /// Returns binary representation string.
        /// </summary>
        private string GetIntBinaryString(int n)
        {
            char[] b = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }
    }
}
