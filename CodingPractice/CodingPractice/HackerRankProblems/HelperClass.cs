using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.HackerRankProblems
{
    public static class HelperClass
    {
        public static int GetMultiplesOfLCMandGCD(int lcm, int gcd)
        {
            int multiple = 0, result = 0;
            while (multiple <= gcd)
            {
                multiple += lcm;
                if (gcd % multiple == 0)
                    result++;
            }
            return result;
        }

        public static int __gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return __gcd(b % a, a);
        }

        //recursive implementation
        public static int LcmOfArray(int[] arr, int idx = 0)
        {
            // lcm(a,b) = (a*b/gcd(a,b))
            if (idx == arr.Length - 1)
            {
                return arr[idx];
            }
            int a = arr[idx];
            int b = LcmOfArray(arr, idx + 1);
            return (a * b / __gcd(a, b)); // __gcd(a,b) is inbuilt library function
        }

        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }

        // Function to find gcd of 
        // array of numbers
        public static int findGCD(int[] arr, int n)
        {
            int result = arr[0];
            for (int i = 1; i < n; i++)
            {
                result = gcd(arr[i], result);

                if (result == 1)
                {
                    return 1;
                }
            }

            return result;
        }
    }
}
