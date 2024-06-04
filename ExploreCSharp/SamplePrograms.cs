using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ExploreCSharp
{
    class SamplePrograms
    {
        public void FibonacciSeries(int numrange)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            Console.Write($"{n1}, {n2}");
            foreach (int i in Enumerable.Range(3, numrange-1))
            {
                n3 = n2 + n1;
                n1 = n2;
                n2 = n3;
                Console.Write($", {n3}");
            }
        }

        public void CovertFirstCharacterCase(string input)
        {
            //string input = "upper case";
            string result = input.ConvertFirstCharCase();
            Console.WriteLine($"\nCase Conversion; Before: {input}, After: {result}");
        }

        // Fast doubling algorithm
        //https://www.nayuki.io/res/fast-fibonacci-algorithms/FastFibonacci.cs
        public BigInteger FastFibonacci(int n)
        {
            BigInteger a = BigInteger.Zero;
            BigInteger b = BigInteger.One;
            for (int i = 31; i >= 0; i--)
            {
                BigInteger d = a * (b * 2 - a);
                BigInteger e = a * a + b * b;
                a = d;
                b = e;
                if ((((uint)n >> i) & 1) != 0)
                {
                    BigInteger c = a + b;
                    a = b;
                    b = c;
                }
            }
            return a;
        }

        
    }
}
