using System;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  C Sharp coding Practice ***********\n", ConsoleColor.Cyan);
            SolveHackerRankProblems();
        }

        public static void SolveHackerRankProblems()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Solve Hacker Rank Problems ***********\n", ConsoleColor.Yellow);
            Pages.HackerRankProblems.PrintSumOfArray();
            Pages.HackerRankProblems.CompareTriplets();
            Pages.HackerRankProblems.SumOfTheArrayElements();
            //Pages.HackerRankProblems.GetTheDiagonalDifferenceOfSquareMatrix();
            Pages.HackerRankProblems.PrintPositiveNegativeZeroRatio();
            Pages.HackerRankProblems.PrintStairCaseProblem(4);
            Pages.HackerRankProblems.PrintMinimumMaximumSum();
            Pages.HackerRankProblems.BirthdayCakeCandles();
            Pages.HackerRankProblems.TimeConversion();
        }
    }
}