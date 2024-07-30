using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.HackerRankProblems
{
    public class WarmupProblems
    {
        public void PrintSumOfArray()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Print sum of integer array ***********\n", ConsoleColor.Green);
            //Given an array of integers, find the sum of its elements.
            List<int> arr = new List<int>() { 1, 5, 7, 3, 8 };
            Console.WriteLine($"Sum of the given integer array is {arr.Sum(e => e)}");
        }

        public void CompareTriplets()
        {
            /* Alice and Bob each created one problem for HackerRank. 
             * A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for 
             * three categories: problem clarity, originality, and difficulty.
            The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for
            Bob's challenge is the triplet b = (b[0], b[1], b[2]).
            The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].

            If a[i] > b[i], then Alice is awarded 1 point.
            If a[i] < b[i], then Bob is awarded 1 point.
            If a[i] = b[i], then neither person receives a point.
            Comparison points is the total points a person earned.
            */
            StaticClassExamples.ColorfulWriteLine("\n***********  Compare the Triplets ***********\n", ConsoleColor.Green);
            List<int> a = new List<int>() { 1, 5, 3 };
            List<int> b = new List<int>() { 7, 3, 8 };
            int x = 0;
            int y = 0;
            List<int> z = new List<int> { };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    x += 1;
                else if (a[i] < b[i])
                    y += 1;
            }
            z.Add(x);
            z.Add(y);
            Console.WriteLine($"Comparision on the triplets point is {string.Join(" ", z)}");
        }

        public void SumOfTheArrayElements()
        {
            /*In this challenge, you are required to calculate and print the sum of the elements
              in an array, keeping in mind that some of those integers may be quite large. */
            StaticClassExamples.ColorfulWriteLine("\n***********  Print sum of Big/Long array ***********\n", ConsoleColor.Green);
            List<long> arr = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            Console.WriteLine($"Sum of the given long array is {arr.Sum(e => e)}");
        }

        public void GetTheDiagonalDifferenceOfSquareMatrix()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  GetThe Diagonal Difference OfSquare Matrix ***********\n", ConsoleColor.Green);
            /*Given a square matrix, calculate the absolute difference between the sums of its diagonals.
            For example, the square matrix  is shown below:
            1 2 3
            4 5 6
            9 8 9  
            The left-to-right diagonal = 1+5+9=15. 
            The right to left diagonal = 3+5+9=17. 
            Their absolute difference is 15-17 = 2.
            Note: the below implement will work only for the 2D list
            */
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            int leftDiagonal = 0;
            int rightDiagonal = 0;
            int size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                leftDiagonal += arr[i, i];
                rightDiagonal += arr[i, size - 1 - i];
            }
            Console.WriteLine($"The absolute difference between sum of its diagonal is {Math.Abs(leftDiagonal - rightDiagonal)}");
        }

        public void PrintPositiveNegativeZeroRatio()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Print Positive Negative Zero Ratio ***********\n", ConsoleColor.Green);
            /*
             Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
            Print the decimal value of each fraction on a new line with  places after the decimal.
            Example
            arr = [1,1,0,-1,-1]
            There are n=5 elements, two positive, two negative and one zero. Their ratios are 2/5,2/5  and 1/5. Results are printed as:

            0.400000
            0.400000
            0.200000
             */
            List<int> arr = new List<int> { -4, 3, -9, 9, 4, -1, 7, 8, 5 };
            int arrLength = arr.Count;
            double positiveNumbersCount = arr.Where(x => x > 0).Count();
            double negativeNumbersCount = arr.Where(x => x < 0).Count();
            double zeroCount = arr.Where(x => x == 0).Count();
            double postiveRatio = Math.Round(positiveNumbersCount / arrLength, 6);
            double negativeRatio = Math.Round(negativeNumbersCount / arrLength, 6);
            double zeroRatio = Math.Round(zeroCount / arrLength, 6);
            Console.WriteLine($"Posive number count is {positiveNumbersCount} and the ratio is {postiveRatio.ToString("N6")}");
            Console.WriteLine($"Negative number count is {negativeNumbersCount} and the ratio is {negativeRatio.ToString("N6")}");
            Console.WriteLine($"Zero count is {zeroCount} and the ratio is {zeroRatio.ToString("N6")}");
        }

        public void PrintStairCaseProblem(int n)
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Print Stair Case Problem ***********\n", ConsoleColor.Green);
            /* Staircase detail:
            This is a staircase of size : n=4
            Output:
               #
              ##
             ###
            ####
            */

            for (int i = 0; i < n; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < n; j++)
                {
                    if (j >= n - 1 - i)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }

        public void PrintMinimumMaximumSum()
        {
            /* Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly 
             * four of the five integers. Then print the respective minimum and maximum values as a 
             * single line of two space-separated long integers.
            Example
            arr = { 1,3,5,7,9}
            The minimum sum is 1+3+5+7 = 16 and the maximum sum is 3+5+7+9 = 24. The function prints
            16 24
            */
            StaticClassExamples.ColorfulWriteLine("\n***********  Print Minimum Maximum Sum ***********\n", ConsoleColor.Green);
            //List<int> arr = new List<int>() { 1,3,5,7,9};            
            List<long> arr = new List<long>() { 256741038, 623958417, 467905213, 714532089, 938071625 };
            //List<long> arr = new List<long>() { 5,5,8,5,9 };  
            long minimumNumber = arr.Min(x => x);
            long maximumNumber = arr.Max(x => x);
            List<long> arrayMin = arr.ToList();
            List<long> arrayMax = arr.ToList();
            arrayMin.Remove(maximumNumber);
            arrayMax.Remove(minimumNumber);
            long minSum = arrayMin.Sum(x => x);
            long maxSum = arrayMax.Sum(x => x);
            Console.WriteLine($"Minimum Sum: {minSum}");
            Console.WriteLine($"Maximum Sum: {maxSum}");
        }

        public void BirthdayCakeCandles()
        {
            /* Count how many candles are tallest.
            Example
            candles=[4,4,1,3]

            The maximum height candles are 4 units high. There are 2 of them, so return 2.
             */
            StaticClassExamples.ColorfulWriteLine("\n***********  Tallest of the Birthday Cake Candles ***********\n", ConsoleColor.Green);
            List<int> candles = new List<int>() { 4, 4, 1, 3 };
            int maxHeight = candles.Max(x => x);
            int maxOccurance = candles.Count(x => x == maxHeight);
            Console.WriteLine($"Maximum height is {maxHeight} and the occurance is {maxOccurance}");
        }

        public void TimeConversion()
        {
            /*
             * Given a time in -hour AM/PM format, convert it to military (24-hour) time.
             * Example:
             * s = "12:01:00PM"
               Return '12:01:00'.
             */
            StaticClassExamples.ColorfulWriteLine("\n***********  Time Conversion ***********\n", ConsoleColor.Green);
            string s = "04:01:00 PM";
            DateTime t = Convert.ToDateTime(s);
            Console.WriteLine(t.ToString("HH:mm:ss"));
        }

        public void FindMedian()
        {
            /*The median of a list of numbers is essentially its middle element after sorting. 
             * The same number of elements occur after it as before. Given a list of numbers with an 
             * odd number of elements, find the median?
             
            Example:
            arr=[3,4,5,2,1,0,6]

            The sorted array [0, 1, 2, 3, 4, 5, 6]. The middle element and the median is 3.
             */
            StaticClassExamples.ColorfulWriteLine("\n***********  Find Median ***********\n", ConsoleColor.Green);
            List<int> arr = new List<int> { 3, 4, 5, 2, 1, 0, 6 };
            arr.Sort();
            var medianIndex = arr.Count / 2;
            Console.WriteLine($"Given list is  {string.Join(' ', arr)} and the median value is {arr[medianIndex]}");
        }

    }
}
