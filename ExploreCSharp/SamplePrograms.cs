using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ExploreCSharp
{
    public class SamplePrograms
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

        public static void SampleTestScenario()
        {
            List<int> a = new List<int> { 17, 28, 30 };
            List<int> b = new List<int> { 99, 16, 8 };
            int x = 0;
            int y = 0;
            List<int> z = new List<int> { };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    x = x + 1;
                else if (a[i] < b[i])
                    y = y + 1;
            }
            z.Add(x);
            z.Add(y);
            Console.WriteLine(String.Join(" ", z));

            var sum = a.Sum(e => e);
            Console.WriteLine($"Sum of the array A is {sum}");
        }

        public static void PrintPositiveNegativeZeroRatio()
        {
            List<int> arr = new List<int> { -4, 3, -9, 9, 4, -1, 7, 8, 5 };
            int arrLength = arr.Count;
            double positiveNumbersCount = arr.Where(x => x > 0).Count();
            double negativeNumbersCount = arr.Where(x => x < 0).Count();
            double zeroCount = arr.Where(x => x == 0).Count();
            double postiveRatio = Math.Round(positiveNumbersCount / arrLength, 6);
            double negativeRatio = Math.Round(negativeNumbersCount / arrLength, 6);
            double zeroRatio = Math.Round(zeroCount / arrLength, 6);
            Console.WriteLine(postiveRatio.ToString("N6"));
            Console.WriteLine(negativeRatio.ToString("N6"));
            Console.WriteLine(zeroRatio.ToString("N6"));
        }


    }
}
