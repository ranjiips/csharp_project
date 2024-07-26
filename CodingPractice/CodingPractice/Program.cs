using System;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  C Sharp coding Practice ***********\n", ConsoleColor.Cyan);
            //SolveWarmUpProblems();
            SolveImplementationProblems();

            Console.WriteLine("\npress any key to exit the process...");
            // basic use of "Console.ReadKey()" method 
            Console.ReadKey();
        }

        public static void SolveWarmUpProblems()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Solve Hacker Rank - Warmup Problems ***********\n", ConsoleColor.Yellow);
            Pages.WarmupProblems.PrintSumOfArray();
            Pages.WarmupProblems.CompareTriplets();
            Pages.WarmupProblems.SumOfTheArrayElements();
            //Pages.WarmupProblems.GetTheDiagonalDifferenceOfSquareMatrix();
            Pages.WarmupProblems.PrintPositiveNegativeZeroRatio();
            Pages.WarmupProblems.PrintStairCaseProblem(4);
            Pages.WarmupProblems.PrintMinimumMaximumSum();
            Pages.WarmupProblems.BirthdayCakeCandles();
            Pages.WarmupProblems.TimeConversion();
        }

        public static void SolveImplementationProblems()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Solve Hacker Rank - Implementation Problems ***********\n", ConsoleColor.Yellow);
            Pages.ImplementationProblems.GradingStudents();
            Pages.ImplementationProblems.CountAppleAndOrange();
            Pages.ImplementationProblems.NumberLineJumps();
            Pages.ImplementationProblems.BetweenTwoSets();
            Pages.ImplementationProblems.BreakingTheRecords();
            Pages.ImplementationProblems.SubarrayDivision();
            Pages.ImplementationProblems.DivisibleSumPairs();
            Pages.ImplementationProblems.MigratoryBirds();
            Pages.ImplementationProblems.DayOfTheProgrammer();
            Pages.ImplementationProblems.BillDivision();
            Pages.ImplementationProblems.SockMerchant();
        }
    }
}