﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExploreCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Explore C Sharp");
            ImplementLinqConcepts();
            ImplementLambdaExpressions();
            ImplementFileHandlingConcepts();
            ImplementSamplePrograms();
            ImplementEmployeeClass();
            ImplementBankClass();
            MethodOverloadingConcepts();
            MethodOverRidingConcepts();
            ImplementEncapsulationConcepts();
            Boxing_Unboxing(5);
            BasicStringOperations();
            sumfunc();
            GenericCollectionConcepts();
            ImplementExtensionMethods();
        }

        public static void sumfunc()
        {
            int i = 0;
            int sum = 0;
            while (i < 100)
            {
                sum = sum + i;
                sum = i + sum;
                i += 1;

            }
            Console.WriteLine($"the sum is: {sum}");
        }

        public static void ImplementLinqConcepts()
        {
            //LINQ Class
            Console.WriteLine("\n***********  Implement Linq Concepts***********\n");
            ExploreLinq linq = new ExploreLinq();
            linq.FindMobilePriceFromList(3);
            linq.FindMobilePriceFromArrayList(8);
            linq.IsTwoListSequenceEqual();

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            linq.GetEvenAndOddNumbersFromList(numbers);

            linq.QueryTheProductDetails(30000);
            linq.QueryTheStudentRecord(7);
            linq.QueryTheStudentRecord(7, 80);
            linq.LinQExpressionExamples();
        }

        public static void ImplementLambdaExpressions()
        {
            Console.WriteLine("\n***********  Implement LambdaExpressions Concepts***********\n");
            ExploreLinq linq = new ExploreLinq();
            linq.SampleLambdaExpressions(5);
        }

        public static void ImplementFileHandlingConcepts()
        {
            //File Handling Class
            Console.WriteLine("\n***********  Implement File Handling Concepts***********\n");
            FileHandling file = new FileHandling();
            //file.ReadContentFromCSV();
            file.ReadContentFromCSVUsingLinq();
        }

        public static void ImplementSamplePrograms()
        {
            //Sample Programs in C#
            Console.WriteLine("\n***********  Implement Sample Programs for Practice***********\n");
            SamplePrograms sp = new SamplePrograms();
            sp.FibonacciSeries(10);
            sp.CovertFirstCharacterCase("upper case");
            sp.CovertFirstCharacterCase("Lower case");

            int n = 7;
            Console.WriteLine("Fast Fibonacci({0}) = {1}", n, sp.FastFibonacci(n));
        }

        public static void ImplementEmployeeClass()
        {
            Console.WriteLine("\n***********  Implement Bank Class Concepts***********\n");
            //Bank class implementation
            BankClass bcObj = new BankClass();
            PermanentEmployee peObj = new PermanentEmployee();
            peObj.EmployeeName = "Ranjith";
            peObj.EmployeeDepartment = "QA";
            peObj.Designation = "Lead";
            peObj.EmploymentType = "Permanent";
            Console.WriteLine($"Salary for {peObj.EmployeeName} is {peObj.CalculateSalary()}");
            Console.WriteLine($"Bonus for {peObj.EmployeeName} is {peObj.GetBonus()}");
        }

        public static void ImplementBankClass()
        {
            Console.WriteLine("\n***********  Implement Account class Concepts***********\n");
            //Account class implementation
            Account accObj = new Account();
            accObj.Name = "Ranjith";
            accObj.AccountNumber = "AA0943567982";
            accObj.CurrentBalance = 23500;

            SavingsAccount saObj = new SavingsAccount();
            Console.WriteLine($"Savings account interest for {accObj.Name} is : {saObj.CalculateInterest(accObj)}");
        }

        public static void MethodOverloadingConcepts()
        {
            Console.WriteLine("\n***********  Implement Method Overloading Concepts***********\n");
            Polymorphism py = new Polymorphism();
            Console.WriteLine($"Add two integers (5,6) is {py.Add(5, 6)}");
            Console.WriteLine($"Add two double values (5.5,8.6) is {py.Add(5.5, 8.6)}");
            Console.WriteLine($"Concatenate two strings (Ranjith, Kumar) is {py.Add("Ranjith", "Kumar")}");
        }

        public static void MethodOverRidingConcepts()
        {
            Console.WriteLine("\n***********  Implement Method Riding Concepts***********\n");
            Animals ani = new Animals();
            Dog dogObj = new Dog();
            Cats catObj = new Cats();

            Console.WriteLine("Calling Base method from Animal Class");
            ani.MakingNoise();
            Console.WriteLine("Calling Override method from Dog Class");
            dogObj.MakingNoise();
            Console.WriteLine("Calling Override method from Cats Class");
            catObj.MakingNoise();
        }

        public static void ImplementEncapsulationConcepts()
        {
            Console.WriteLine("\n***********  Implement Encapsulation Concepts***********\n");

            Encapsulation encObj = new Encapsulation("Chennai");
            encObj.Name = "Ranjith";
            encObj.Birthdate = new DateTime(1985, 02, 10);
            encObj.Country = "India";
            encObj.DisplayDetails();
        }
        public static void Boxing_Unboxing(int i)
        {
            Console.WriteLine("\n***********  Implement Boxing and Unboxing Concepts***********\n");
            object a = i;   //boxing
            int j = (int)a;   //unboxing
            Console.WriteLine($"Boxing: {a}");
            Console.WriteLine($"Unboxing: {j}");
        }

        public static void BasicStringOperations()
        {
            Console.WriteLine("\n***********  Implement Basic String Operations Concepts***********\n");

            StringOperations strObj = new StringOperations();
            string str1 = "Ranjith";
            string str2 = "Kumar";
            string str3 = " This is the sample line to perform the string operations ";

            strObj.ConcatenateStrings(str1, str2);
            strObj.StringBuilderExamples(str1, str2);
            strObj.ReplaceGivenValueInString(str3, "i", "ZZ");
            Console.WriteLine($"Is the string '{str3}' contains 'o': {strObj.IsStringContains(str3, "o")}");
            strObj.TrimSpaces(str3);
        }

        public static void GenericCollectionConcepts()
        {
            Console.WriteLine("\n***********  Implement Generics and Collection Concepts***********\n");
            GenericCollections gc = new GenericCollections();
            gc.UsingList();
            gc.UsingDictionary();
            gc.UsingStack();
            gc.UsingQueue();
        }
        public static void ImplementExtensionMethods()
        {
            Console.WriteLine("\n***********  Implement Extension Method Concepts***********\n");
            StringOperations strObj = new StringOperations();
            string post = "I am trying to implement the string extension method concepts by extending the String class";
            strObj.ImplementExtensionMethodConcepts(post);

            IEnumerable<int> numbers = new List<int>() { 1,22,53,14,75,60,47};
            var max = numbers.Max();
            Console.WriteLine($"The maximum number from the given list is: {max}");

        }
    }
}
