using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.HackerRankProblems
{
    public class ImplementationProblems
    {
        public void GradingStudents()
        {
            /*HackerLand University has the following grading policy:

            Every student receives a grade in the inclusive range from 0 to 100.
            Any grade less than 40 is a failing grade.
            Sam is a professor at the university and likes to round each student's grade according to these rules:

            If the difference between the grade and the next multiple of 5 is less than 3,
            round grade up to the next multiple of 5.
            If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.
            Examples

             grade = 84, round to 85 (85 - 84 is less than 3)
             grade = 29 do not round (result is less than 40)
             grade = 57, do not round (60 - 57 is 3 or higher)
            
            ID  Original Grade   Final Grade
            1   73               75
            2   67               67
            3   38               40
            4   33               33
             */
            StaticClassExamples.ColorfulWriteLine("\n***********  Grading Students ***********\n", ConsoleColor.Green);
            List<int> grade = new List<int>() { 73, 67, 38, 33};
            List<int> updatedGrade = new List<int>();

            foreach (int gradeId in grade)
            {
                Console.Write(gradeId + " ");
                int diff = 5 - (gradeId % 5);
                if(gradeId>37 && diff < 3)
                    updatedGrade.Add(gradeId+diff);
                else
                    updatedGrade.Add(gradeId);
            }
            Console.WriteLine();
            Console.Write(String.Join(" ", updatedGrade));
        }

        public void CountAppleAndOrange()
        {
            /* Function Description

            Complete the countApplesAndOranges function in the editor below. It should print the number of apples and oranges that land on Sam's house, each on a separate line.

            countApplesAndOranges has the following parameter(s):

            s: integer, starting point of Sam's house location.
            t: integer, ending location of Sam's house location.
            a: integer, location of the Apple tree.
            b: integer, location of the Orange tree.
            apples: integer array, distances at which each apple falls from the tree.
            oranges: integer array, distances at which each orange falls from the tree.
            Input Format

            The first line contains two space-separated integers denoting the respective values of s and t.
            The second line contains two space-separated integers denoting the respective values of a and b.
            The third line contains two space-separated integers denoting the respective values of m and n.
            The fourth line contains m space-separated integers denoting the respective distances that each apple falls from point a.
            The fifth line contains n space-separated integers denoting the respective distances that each orange falls from point b.
            
            Sample Input:
            7 11
            5 15
            3 2
            -2 2 1
            5 -6

            Sample Output:
            1
            1
             */

            StaticClassExamples.ColorfulWriteLine("\n***********  Count Apple AndOrange ***********\n", ConsoleColor.Green);
            int s =7, t = 11;
            int a = 5, b = 15;
            List< int > apples = new List<int>() { -2, 2, 4};
            List<int> oranges = new List<int>() { 5, -6, 0};
            int appleInRange = 0, orangeInRange = 0;

            foreach (int apple in apples)
            {
                int x = a + apple;
                if(x>=s && x<=t)
                    appleInRange++;
            }

            foreach (int orange in oranges)
            {
                int x = b + orange;
                if (x >= s && x <= t)
                    orangeInRange++;
            }
            Console.WriteLine($"Number of apples falling in the range {s}-{t} is {appleInRange}");
            Console.WriteLine($"Number of oranges falling in the range {s}-{t} is {orangeInRange}");
        }

        public void NumberLineJumps()
        {
            /*You are given two kangaroos on a number line ready to jump in the positive direction (i.e, toward positive infinity).

            The first kangaroo starts at location x1 and moves at a rate of v1 meters per jump.
            The second kangaroo starts at location x2 and moves at a rate of v2 meters per jump.
            You have to figure out a way to get both kangaroos at the same location at the same time as part of the show. If it is possible, return YES, otherwise return NO.
            
            int x1, int v1: starting position and jump distance for kangaroo 1
            int x2, int v2: starting position and jump distance for kangaroo 2
            
            Example:
            x1 = 2; v1 = 1
            x2 = 1; v2 = 2

            After one jump, they are both at x=3, (x1+v1=2+1, x2+v2=1+2 ), so the answer is YES.
            
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Kangaroo Number Line Jumps ***********\n", ConsoleColor.Green);

            int x1 = 0, v1 = 3; //0   2
            int x2 = 5, v2 = 2; //5   3

            Console.WriteLine("******************* Approach 1***************************");
            int itrCount = 1;
            string flag = "NO";
            bool x = false;
            if (x1 < x2)
            {
                if (v1 > v2)
                { x = true; }
            }
            else if (x1 > x2)
            {
                if (v1 < v2)
                { x = true; }
            }
            Console.WriteLine(x);
            if (x)
            {
                while (itrCount < 10000)
                {
                    x1 += v1;
                    x2 += v2;
                    if (x1 == x2)
                    {
                        flag = "Yes";
                        break;
                    }
                    itrCount++;
                }
            }
            Console.WriteLine($"Iteration Count = {itrCount}, the flag value is {flag}");

            Console.WriteLine("******************* Approach 2***************************");
            if (v1 > v2 && (x2 - x1) % (v1 - v2) == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }

        public void BetweenTwoSets()
        {
            /* https://www.hackerrank.com/challenges/between-two-sets/problem
             * https://www.youtube.com/watch?v=-c_V4fQ2mKU
            There will be two arrays of integers. Determine all integers that satisfy the following two conditions:
            The elements of the first array are all factors of the integer being considered
            The integer being considered is a factor of all elements of the second array

            Sample Input:
            2 3
            2 4
            16 32 96

            Sample Output:
            3

            Explanation:
            2 and 4 divide evenly into 4, 8, 12 and 16.
            4, 8 and 16 divide evenly into 16, 32, 96.
            4, 8 and 16 are the only three numbers for which each element of a is a factor and each is a factor of all elements of b.
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Between Two Sets ***********\n", ConsoleColor.Green);

            List<int> a = new List<int>() { 2,6};
            List<int> b = new List<int>() { 24, 36};
            int[] arr1=a.ToArray();
            int[] arr2=b.ToArray();
            int lcm = HelperClass.LcmOfArray(arr1);
            int gcd = HelperClass.findGCD(arr2, arr2.Length);

            Console.WriteLine($"LCM of the given array is {lcm}");
            Console.WriteLine($"GCD of the given array is {gcd}");
            Console.WriteLine($"Count of multiples of LCM that divides GCD is {HelperClass.GetMultiplesOfLCMandGCD(lcm,gcd)}");
        }

        public void BreakingTheRecords()
        {
            /*Maria plays college basketball and wants to go pro. Each season she maintains a record of her play. She tabulates the number of times she breaks her season record for most points and least points in a game. Points scored in the first game establish her record for the season, and she begins counting from there.

            Example
            scores = [12,24,10,24]
            Scores are in the same order as the games played. She tabulates her results as follows:

                                                 Count
                Game  Score  Minimum  Maximum   Min Max
                 0      12     12       12       0   0
                 1      24     12       24       0   1
                 2      10     10       24       1   1
                 3      24     10       24       1   1
            Given the scores for a season, determine the number of times Maria breaks her records for most and least points scored during the season.
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Breaking The Own Records ***********\n", ConsoleColor.Green);
            List<int> scores = new List<int>() { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            int highestScore = 0, lowestScore = 0, highCounter = 0, lowCounter = 0;
            int iterationCount = 0;
            List<int> results = new List<int>();
            foreach (int i in scores)
            {
                if (iterationCount == 0)
                {
                    highestScore = i; lowestScore = i;
                }
                else
                {
                    if (i > highestScore)
                    {
                        highestScore = i;
                        highCounter++;
                    }
                    else if (i < lowestScore)
                    {
                        lowestScore = i;
                        lowCounter++;
                    }
                }

                iterationCount++;
            }
            results.Add(highestScore);
            results.Add(lowestScore);
            Console.WriteLine($"Highest Score: {highestScore}, Lowest Score: {lowestScore}");
            Console.WriteLine($"Highest Counter: {highCounter}, Lowest Counter: {lowCounter}");
        }
    }
}
