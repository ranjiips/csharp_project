using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public void SubarrayDivision()
        {
            /*Two children, Lily and Ron, want to share a chocolate bar. Each of the squares has an integer on it.

            Lily decides to share a contiguous segment of the bar selected such that:

            The length of the segment matches Ron's birth month, and,
            The sum of the integers on the squares is equal to his birth day.
            Determine how many ways she can divide the chocolate.

            Function Description:
            birthday has the following parameter(s):

            int s[n]: the numbers on each of the squares of chocolate
            int d: Ron's birth day
            int m: Ron's birth month
            
            Returns:
            int: the number of ways the bar can be divided
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Subarray Division ***********\n", ConsoleColor.Green);

            List<int> chocolates = new List<int>() { 2,2,1,3,2 };
            int d = 4;
            int m = 2;
            //int arrLen = chocolates.Count;
            int matchCounter = 0;
            for (int i = 0; i < chocolates.Count; i++)
            {
                var sublist = chocolates.Skip(i).Take(m).ToList();
                if (sublist.Sum() == d)
                    matchCounter++;
            }
            Console.WriteLine($"Matching age is {matchCounter}");

        }

        public void DivisibleSumPairs()
        {
            /*Given an array of integers and a positive integer k, determine the number of (i,j) pairs where i<j and ar[i] + ar[j]
             * is divisible by k.

            Example:
            ar=[1,2,3,4,5,6]
            k=5
            Three pairs meet the criteria: [1,4],[2,3] and [4,6].
            Returns
            - int: the number of pairs
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Divisible Sum Pairs ***********\n", ConsoleColor.Green);
            List<int> ar = new List<int> { 1, 3, 2, 6, 1, 2 };
            int k = 3;
            int counter = 0;
            for(int i = 0; i < ar.Count;i++)
            {
                for(int j = i+1; j < ar.Count; j++)
                {
                    Console.WriteLine($"{ar[i]}, {ar[j]}, {(ar[i] + ar[j]) % k}");
                    if ((ar[i] + ar[j]) % k == 0)
                        counter++;
                }
            }
            Console.WriteLine($"Total sum pairs is {counter}");
        }

        public void MigratoryBirds()
        {
            /*Given an array of bird sightings where every element represents a bird type id, 
             * determine the id of the most frequently sighted type. If more than 1 type has been spotted that maximum amount, 
             * return the smallest of their ids.

            Example
            arr=[1,1,2,2,3]

            There are two each of types 1 and 2, and one sighting of type 3. Pick the lower of the two types seen twice: type 1.
            
            Returns:
            int: the lowest type id of the most frequently sighted birds
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Migratory Birds ***********\n", ConsoleColor.Green);
            List<int> arr = new List<int> { 1, 4, 4, 4, 5, 3, 1, 1 };
            int listCount = arr.Count;
            int[] dummyArray = new int[listCount+1];
            Array.Fill(dummyArray, 0);
            for(int i = 0;i< listCount;i++)
            {
                int j = arr[i];
                dummyArray[j] += 1;
            }
            var dummyList = dummyArray.ToList();
            var index = dummyList.FindIndex(x => x == dummyList.Max());
            Console.WriteLine(index);
            foreach(int i in dummyArray)
            {
                Console.Write(i+" ");
            }
        }

        public void DayOfTheProgrammer()
        {
            /*Marie invented a Time Machine and wants to test it by time-traveling to visit Russia on the Day of the Programmer 
             * (the 256th day of the year) during a year in the inclusive range from 1700 to 2700.
            From 1700 to 1917, Russia's official calendar was the Julian calendar; since 1919 they used the Gregorian calendar system. 
            The transition from the Julian to Gregorian calendar system occurred in 1918, when the next day after January 31st was 
            February 14th. This means that in 1918, February 14th was the 32nd day of the year in Russia.
            In both calendar systems, February is the only month with a variable amount of days; it has 29 days during a leap year, 
            and 28 days during all other years. In the Julian calendar, leap years are divisible by 4; in the Gregorian calendar, 
            leap years are either of the following:

            Divisible by 400.
            Divisible by 4 and not divisible by 100.

            Given a year, y, find the date of the 256th day of that year according to the official Russian calendar during that year. 
            Then print it in the format dd.mm.yyyy, where dd is the two-digit day, mm is the two-digit month, and yyyy is y.

            For example, the given  year= 1984. 1984 is divisible by 4, so it is a leap year. 
            The 256th day of a leap year after 1918 is September 12, 
            so the answer is 12.09.1984.
             * 
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Day of the Programmer ***********\n", ConsoleColor.Green);
            int year = 1920;

            if (year == 1918)
                Console.WriteLine("26.09.2018");
            else if (year < 1917 && year% 4 == 0)
                Console.WriteLine($"12.09.{year}");
            else if (year > 1918 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
                Console.WriteLine($"12.09.{year}");
            else
                Console.WriteLine($"13.09.{year}");
        }

        public void BillDivision()
        {
            /*Two friends Anna and Brian, are deciding how to split the bill at a dinner. Each will only pay for the items they consume. 
             * Brian gets the check and calculates Anna's portion. You must determine if his calculation is correct.

            For example, assume the bill has the following prices: bill=[2,4,6]. Anna declines to eat item bill[2] which costs 6. 
            If Brian calculates the bill correctly, Anna will pay (2+4)/2=3. If he includes the cost of bill[2], 
            he will calculate (2+4+6)/2=6. In the second case, he should refund 3 to Anna.

            Function Description

            Complete the bonAppetit function in the editor below. It should print Bon Appetit if the bill is fairly split. 
            Otherwise, it should print the integer amount of money that Brian owes Anna.

            bonAppetit has the following parameter(s):

            bill: an array of integers representing the cost of each item ordered
            k: an integer representing the zero-based index of the item Anna doesn't eat
            b: the amount of money that Anna contributed to the bill

            Example:
            If Brian did not overcharge Anna, print Bon Appetit on a new line; otherwise, print the difference (i.e.,charged-actual )
            that Brian must refund to Anna. This will always be an integer.

            item=4 
            didnot eat item=1
            3 10 2 9
            12
            Output:
            5
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Bill Division ***********\n", ConsoleColor.Green);
            List<int> itemBill = new List<int>() { 72, 53, 60, 66, 90, 62, 12, 31, 36, 94 };
            int k = 6;
            int b = 288;

            int totalBillAmount = itemBill.Sum(x => x);
            int getValueByIndex = itemBill.ElementAt(k);
            int shareWithoutItem = totalBillAmount- getValueByIndex;

            Console.WriteLine($"Total Share: {totalBillAmount}, Item did not eat by Anna: {getValueByIndex}");
            Console.WriteLine($"Bill execulding the item which does not eat by Anna: {shareWithoutItem}");
            Console.WriteLine($"Actual Share: {totalBillAmount/2}, Anna Share: {shareWithoutItem/2}, Anna Paid: {b}, Refund to Anna: {b-(shareWithoutItem / 2)}");
            
            if (shareWithoutItem / 2 == b)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(b - (shareWithoutItem / 2));
        }

        public void SockMerchant()
        {
            /*There is a large pile of socks that must be paired by color. 
             * Given an array of integers representing the color of each sock,
             * determine how many pairs of socks with matching colors there are.

            Example:
            n=7
            ar=[1,2,1,2,1,3,2]

            There is one pair of color 1 and one of color 2. There are three odd socks left, 
            one of each color. The number of pairs is 2.
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Sock Merchant ***********\n", ConsoleColor.Green);
            //List<int> ar = new List<int>() { 1, 2, 1, 2, 1, 3, 2 };
            List<int> ar = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            Console.WriteLine($"Original elements are {string.Join(' ', ar)}");
            var distinctItems = ar.Distinct();
            Console.WriteLine($"Distinct elements are {string.Join(' ', distinctItems)}");
            int pairs = 0;
            foreach( int i in distinctItems )
            {
                //var occurance = ar.Sum(x=>x==i).Count();
                var occurance = ar.Count(x=>x==i);
                Console.WriteLine($"Total number of Socks {i} is {occurance} and the pair is {occurance/2}");
                if(occurance/2>0)
                    pairs=pairs+ (occurance / 2);
            }
            Console.WriteLine($"Total  number of pairs:{pairs}");
        }

        public void DrawingBook()
        {
            /*A teacher asks the class to open their books to a page number. 
             * A student can either start turning pages from the front of the book or from the back of the book.
             * They always turn pages one at a time. When they open the book, page 1 is always on the right side:

            When they flip page 1, they see pages 2 and 3. Each page except the last page will always 
            be printed on both sides. The last page may only be printed on the front, given the length of 
            the book. If the book is n pages long, and a student wants to turn to page p, 
            what is the minimum number of pages to turn? They can start at the beginning or the end of the book.

            Given n and p, find and print the minimum number of pages that must be turned in order to 
            arrive at page p.

            Example:
            n=5; p=3
            if the student wants to get to page 3, they open the book to page 1, flip 1 page and they 
            are on the correct page. If they open the book to the last page, page 5, they turn 1 page and 
            are at the correct page. Return 1
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Drawing Books ***********\n", ConsoleColor.Green);
            int pages = 19;
            int n = pages;
            int p = 12;
            int totalFlips = n / 2;
            int flip = 0;
            if (p > totalFlips)
            {
                for (int i = 0; i < totalFlips; i++)
                {
                    if(n==p)
                    {
                        flip = i; break;
                    }
                    else if(n%2==0)
                    {
                        if (n == p || (n + 1) == p)
                        { flip = i; break; }
                        else
                            n -= 2;
                    }
                    else
                    {
                        if (n == p || (n - 1) == p)
                        { flip = i; break; }
                        else
                            n -= 2;
                    }
                }
            }
            else
            {
                for (int i = 0; i < totalFlips; i++)
                {
                    if (i==0&&(i+1)==p)
                    {
                        flip = i; break;
                    }
                    else if(flip>0 && (flip == p || (flip + 1) == p))
                    {
                        flip = i; break;
                    }
                    else
                    {
                        flip += 2;
                    }
                }
            }

            Console.WriteLine($"Total number of pages: {pages}, Page to navigate: {p}, Number of flips: {flip}");
        }

        public void CountingValleys()
        {
            /*An avid hiker keeps meticulous records of their hikes. During the last hike that took exactly
             * 'steps' steps, for every step it was noted if it was an uphill, U , or a downhill, D  step.
             * Hikes always start and end at sea level, and each step up or down represents a  unit change in altitude. We define the following terms:

            A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
            A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
            Given the sequence of up and down steps during a hike, find and print the number of valleys walked through.

            Example
            step=8
            path=[DDUUUUDD] 

            The hiker first enters a valley 2 units deep. 
            Then they climb out and up onto a mountain 2 units high. 
            Finally, the hiker returns to sea level and ends the hike.
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Counting Valleys ***********\n", ConsoleColor.Green);
            int steps = 8;
            string path = "UDDDUDUU";
            char[] pathValue = path.ToCharArray();
            int currStep = 0;
            int prevStep = 0;
            int valley = 0;


            foreach(char c in pathValue)
            {
                prevStep = currStep;
                if (c == 'D')
                    currStep--;
                else
                    currStep++;

                if(currStep==0 && prevStep==-1)
                    valley++;
            }
            Console.WriteLine($"Number of valleys travelled: {valley}");
        }

        public void ElectronicShops()
        {
            /*A person wants to determine the most expensive computer keyboard and USB drive that can be 
             * purchased with a give budget. Given price lists for keyboards and USB drives and a budget, 
             * find the cost to buy them. If it is not possible to buy both items, return -1.

            Example:
            b=60; k=[40,50,60], u=[5,8,12]

            The person can buy a 40 keyboard + 12 USB drive, or a 50 keyboard + 8 USB drive. 
            Choose the latter as the more expensive option and return 58.
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Electronic Shops ***********\n", ConsoleColor.Green);
            int budget = 60;
            int[] keyboards = { 40, 50, 60 };
            int[] drives = { 25, 28, 12 };
            int expensivePrice = 0;

            foreach (int k in keyboards)
                foreach (int u in drives)
                {
                    int price = k + u;
                    if (price > expensivePrice && price <= budget)
                        expensivePrice = price;
                }
            if (expensivePrice == 0)
                expensivePrice = -1;
            Console.WriteLine($"The expensive purchase is {expensivePrice}");
        }

        public void CatAndMouse()
        {
            /*Two cats and a mouse are at various positions on a line. 
             * You will be given their starting positions. Your task is to determine which cat 
             * will reach the mouse first, assuming the mouse does not move and the cats travel 
             * at equal speed. If the cats arrive at the same time, the mouse will be allowed to 
             * move and it will escape while they fight.

            You are given q queries in the form of x, y, and z representing the respective positions 
            for cats A and B, and for mouse C. Complete the function to return the appropriate answer 
            to each query, which will be printed on a new line.

            If cat A catches the mouse first, print Cat A.
            If cat B catches the mouse first, print Cat B.
            If both cats reach the mouse at the same time, print Mouse C as the two cats fight 
            and mouse escapes.
            
            Example:
            x=2, y=5, z=4

            The cats are at positions 2 (Cat A) and 5 (Cat B), and the mouse is at position 4. 
            Cat B, at position 5 will arrive first since it is only 1 unit away while the other is 2 units
            away. Return 'Cat B'.
             */
            StaticClassExamples.ColorfulWriteLine("\n*********** Cat and Mouse ***********\n", ConsoleColor.Green);

            int x = 2;
            int y = 5;
            int z = 4;

            if (Math.Abs(x - z) < Math.Abs(y - z))
                Console.WriteLine("Cat A catches the mouse");
            else if (Math.Abs(x - z) > Math.Abs(y - z))
                Console.WriteLine("Cat B catches the mouse");
            else
                Console.WriteLine("Mouse C escapes, since both the cat are busy in fighting");
        }
    }
}
