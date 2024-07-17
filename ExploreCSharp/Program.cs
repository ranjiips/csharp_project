using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AventStack.ExtentReports.Reporter;
using ExploreCSharp.SeleniumWeb;
using Microsoft.Office.Interop.Excel;

namespace ExploreCSharp
{
    class Program
    {
        static AventStack.ExtentReports.ExtentReports extent;
        static void Main(string[] args)
        {
            //ExtentReportsFunction();
            Console.WriteLine("Explore C Sharp");
            //ImplementLinqConcepts();
            //ImplementCSVFileHandlingConcepts();
            //ImplementExcelFileHandlingConcepts();
            //ImplementSamplePrograms();
            //ImplementEmployeeClass();
            //ImplementBankClass();
            //MethodOverloadingConcepts();
            //MethodOverRidingConcepts();
            //ImplementEncapsulationConcepts();
            //Boxing_Unboxing(5);
            //BasicStringOperations();
            //sumfunc();
            //GenericCollectionConcepts();
            //ImplementExtensionMethods();
            //ImplementRestAPIMethods();
            //ImplementJsonConcepts();
            //ImplementSeleniumConcepts();
            //ImplementEnumerationConcepts();
            //CountTheCharacters("abcdabcdpqr");
            //ImplementInterfaceConcepts();
            //SampleTestScenario();
            SampleProgram();
        }

        public static void SampleProgram()
        {
            string somevalue = "ed@#12.45$%23";
            for(int i=0; i<somevalue.Length; i++)
            {
                if(char.IsDigit(somevalue[i]) || somevalue[i].ToString()==".")
                    Console.Write($"{somevalue[i]}");
            }
        }

        public static void ExtentReportsFunction()
        {
            var reportFolderLocation = Environment.CurrentDirectory + @"\Reports";
            Directory.CreateDirectory(reportFolderLocation);
            ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(reportFolderLocation);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlreport);
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
            //Console.WriteLine($"the sum is: {sum}");
            string message = $"the sum is: {sum}";
            StaticClassExamples.ColorfulWriteLine(message, ConsoleColor.White);
        }

        public static void ImplementLinqConcepts()
        {
            //LINQ Class
            string message = $"\n***********  Implement Linq Concepts***********\n";
            StaticClassExamples.ColorfulWriteLine(message, ConsoleColor.Cyan);
            //Console.WriteLine("\n***********  Implement Linq Concepts***********\n");            
            Pages.ExploreLinq.FindMobilePriceFromList(3);
            Pages.ExploreLinq.FindMobilePriceFromArrayList(8);
            Pages.ExploreLinq.IsTwoListSequenceEqual();

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Pages.ExploreLinq.GetEvenAndOddNumbersFromList(numbers);

            Pages.ExploreLinq.QueryTheProductDetails(30000);
            Pages.ExploreLinq.QueryTheStudentRecord(7);
            Pages.ExploreLinq.QueryTheStudentRecord(7, 80);
            Pages.ExploreLinq.LinQExpressionExamples();

            Pages.ExploreLinq.SortTheStuduentRecords();
            Pages.ExploreLinq.RemoveDuplicatesFromStringArrayUsingLinq();

            //Console.WriteLine("\n***********  Implement LambdaExpressions Concepts***********\n");
            string msg = "\n***********  Implement LambdaExpressions Concepts***********\n";
            StaticClassExamples.ColorfulWriteLine(msg, ConsoleColor.Yellow);
            Pages.ExploreLinq.SampleLambdaExpressions(5);
            Pages.ExploreLinq.GetValuesBasedOnType();
            Pages.ExploreLinq.OrderByFunction();
            Pages.ExploreLinq.GroupByFunction();
            Pages.ExploreLinq.JoinFunctions();
            Pages.ExploreLinq.GetIntegerFromTheString();
            Pages.ExploreLinq.FetchTheIntegerValues();
        }

        public static void ImplementCSVFileHandlingConcepts()
        {
            //File Handling Class
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement CSV File Handling Concepts***********\n",ConsoleColor.Green);
            string filePath = "C:/Ranjith/Learnings/Projects/itemdetails.csv";
            Pages.FileHandlingCSV.ReadContentFromCSV(filePath);
            Pages.FileHandlingCSV.ReadCSVContentLineByLine(filePath);
            //csvfile.ReadCSVContentLineByLine(filePath, "Car");
            Pages.FileHandlingCSV.ReadCSVContentLineByLine(filePath, "Bus");
        }

        public static void ImplementExcelFileHandlingConcepts()
        {
            //File Handling Class
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Excel File Handling Concepts***********\n",ConsoleColor.Red);
            //string filePath = "C:/Ranjith/Learnings/Projects/itemdetails.xlsx";
            Console.WriteLine($"Excel content: {Pages.FileHandlingExcel.ReadCell(0, 0)}");
            Pages.FileHandlingExcel.WriteGivenCell("B10","SampleText");
            Pages.FileHandlingExcel.ReadGivenCell("B10");
            Console.WriteLine("-------------------------------------------------\n");
            Pages.FileHandlingExcel.WriteGivenCellRange("B2:B6", "SampleText");
            Pages.FileHandlingExcel.ReadCellRange();
            Console.WriteLine("-------------------------------------------------\n");
            Pages.FileHandlingExcel.WriteMulitpleCells();
            Pages.FileHandlingExcel.ReadCellRange();
            //excelfile.SaveWorkboox();
        }

        public static void ImplementSamplePrograms()
        {
            //Sample Programs in C#
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Sample Programs for Practice***********\n", ConsoleColor.DarkCyan);
            Pages.SamplePrograms.FibonacciSeries(10);
            Pages.SamplePrograms.CovertFirstCharacterCase("upper case");
            Pages.SamplePrograms.CovertFirstCharacterCase("Lower case");

            int n = 7;
            Console.WriteLine("Fast Fibonacci({0}) = {1}", n, Pages.SamplePrograms.FastFibonacci(n));
        }

        public static void ImplementEmployeeClass()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Bank Class Concepts***********\n", ConsoleColor.Red);
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
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Bank Account class Concepts***********\n", ConsoleColor.White);
            //Account class implementation
            BankClass accObj = new BankClass();
            accObj.Name = "Ranjith";
            accObj.AccountNumber = "AA0943567982";
            accObj.CurrentBalance = 23500;

            SavingsAccount saObj = new SavingsAccount();
            Console.WriteLine($"Savings account interest for {accObj.Name} is : {saObj.CalculateInterest(accObj)}");
        }

        public static void MethodOverloadingConcepts()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Method Overloading Concepts***********\n", ConsoleColor.Yellow);
            Console.WriteLine($"Add two integers (5,6) is {Pages.Polymorphism.Add(5, 6)}");
            Console.WriteLine($"Add two double values (5.5,8.6) is {Pages.Polymorphism.Add(5.5, 8.6)}");
            Console.WriteLine($"Concatenate two strings (Ranjith, Kumar) is {Pages.Polymorphism.Add("Ranjith", "Kumar")}");
        }

        public static void MethodOverRidingConcepts()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Method Riding Concepts***********\n", ConsoleColor.White);
            
            Dog dogObj = new Dog();
            //Cats catObj = new Cats();
            Animals ani = new Cats();

            Console.WriteLine("Calling Base method from Animal Class");
            ani.MakingNoise();
            Console.WriteLine("Calling Override method from Dog Class");
            dogObj.MakingNoise();
            Console.WriteLine("Calling Override method from Cats Class");
            ani.MakingNoise();
        }

        public static void ImplementEncapsulationConcepts()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Encapsulation Concepts***********\n", ConsoleColor.Magenta);

            Pages.Encapsulation.Name = "Ranjith";
            Pages.Encapsulation.Birthdate = new DateTime(1985, 02, 10);
            Pages.Encapsulation.Country = "India";
            Pages.Encapsulation.DisplayDetails();
        }
        public static void Boxing_Unboxing(int i)
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Boxing and Unboxing Concepts***********\n", ConsoleColor.Red);
            object a = i;   //boxing
            int j = (int)a;   //unboxing
            Console.WriteLine($"Boxing: {a}");
            Console.WriteLine($"Unboxing: {j}");
        }

        public static void BasicStringOperations()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Basic String Operations Concepts***********\n", ConsoleColor.DarkCyan);

            string str1 = "Ranjith";
            string str2 = "Kumar";
            string str3 = " This is the sample line to perform the string operations ";

            Pages.StringOperations.ConcatenateStrings(str1, str2);
            Pages.StringOperations.StringBuilderExamples(str1, str2);
            Pages.StringOperations.ReplaceGivenValueInString(str3, "i", "ZZ");
            Console.WriteLine($"Is the string '{str3}' contains 'o': {Pages.StringOperations.IsStringContains(str3, "o")}");
            Pages.StringOperations.TrimSpaces(str3);
        }

        public static void GenericCollectionConcepts()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Generics and Collection Concepts***********\n", ConsoleColor.DarkYellow);
            Pages.GenericCollections.UsingList();
            Pages.GenericCollections.UsingDictionary();
            Pages.GenericCollections.UsingStack();
            Pages.GenericCollections.UsingQueue();
            Pages.GenericCollections.RemoveDuplicatesFromStringArrayList();
            Pages.GenericCollections.UsingHashTable();
        }
        public static void ImplementExtensionMethods()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Extension Method Concepts***********\n", ConsoleColor.DarkBlue);
            string post = "I am trying to implement the string extension method concepts by extending the String class";
            Pages.StringOperations.ImplementExtensionMethodConcepts(post);

            IEnumerable<int> numbers = new List<int>() { 1,22,53,14,75,60,47};
            var max = numbers.Max();
            Console.WriteLine($"The maximum number from the given list is: {max}");

        }

        public static void ImplementRestAPIMethods()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Rest API Methods***********\n", ConsoleColor.Yellow);
            //string apiurl = "https://rahulshettyacademy.com";
            string getbookapiurl = "/Library/GetBook.php";
            string queryParam = $"{getbookapiurl}?ID=AABD445";
            //HandleAPIs apiObj = new HandleAPIs();
            Pages.HandleAPIs.DeleteBookAPI("/Library/DeleteBook.php", "AABD445");
            Pages.HandleAPIs.PostRequestAPIWithOutAuth("/Library/Addbook.php");
            Pages.HandleAPIs.GetRequestAPIWithOutAuth(queryParam);
            //Pages.HandleAPIs.GetRequestAPIUsingAsyncMethod();
        }

        public static void ImplementJsonConcepts()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Json Methods***********\n", ConsoleColor.Magenta);
            var SingleJsonObject = Pages.FileHandlingJSON.GetJsonObject();
            StaticClassExamples.ColorfulWriteLine($"{SingleJsonObject} \n", ConsoleColor.Cyan);
            int jsonCount = Pages.FileHandlingJSON.GetValuesUsingIndex(SingleJsonObject);
            int jsonObjCount = Pages.FileHandlingJSON.GetValuesUsingValueMethod(SingleJsonObject);
            Pages.FileHandlingJSON.GetValuesFromJsonJTokenParseMethod(SingleJsonObject);
        }

        public static void ImplementSeleniumConcepts()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Selenium Web Interaction Concepts***********\n", ConsoleColor.Magenta);
            string baseurl = "https://the-internet.herokuapp.com/";

            Pages.SeleniumLoginLogoutActions.NavigateToURL(baseurl);

            Pages.SeleniumLoginLogoutActions.LoginPageUsingFormAuthentication("Form Authentication");
            
            //Pages.SeleniumLoginLogoutActions.EnterBasicAuthinJSPopup();            

            Pages.SeleniumLoginLogoutActions.HandleCheckBoxes("Checkboxes");

            Pages.SeleniumLoginLogoutActions.HandleDragDrop("Drag and Drop");

            Pages.SeleniumLoginLogoutActions.HandleFrames("Frames");
            
            Pages.SeleniumLoginLogoutActions.HandleMultipleWindows("Multiple Windows");

            Pages.SeleniumLoginLogoutActions.CloseBrowser();
        }

        public static void ImplementEnumerationConcepts()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Enumeration Concepts***********\n", ConsoleColor.Green);
            
            EnumerationExamples enumex1 = new EnumerationExamples(EnumerationExamples.SelectNumbers.Four);
            EnumerationExamples enumex2 = new EnumerationExamples(EnumerationExamples.SelectNumbers.Zero);
            EnumerationExamples enumex3 = new EnumerationExamples(EnumerationExamples.SelectNumbers.Six);
            
            enumex1.PrintTheNumber();
            enumex2.PrintTheNumber();
            enumex3.PrintTheNumber();
        }

        public static void CountTheCharacters(string value)
        {
            List<char> characters = value.ToList();
            foreach (char c in characters)
            {
                Console.WriteLine(c);
                var count = characters.Count(e => e == c);
                Console.WriteLine($"Character: {c}, Count is {count}");
            }
        }

        public static void ImplementInterfaceConcepts()
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Implement Interface Concepts***********\n", ConsoleColor.Yellow);
            Console.WriteLine($"The sum of 5 and 6 is {Pages.HandleInterfaces.AddTwoNumbers(5, 6)}");
        }

        public static void SampleTestScenario()
        {
            List<int> arr = new List<int> {0,0,-1,1,1};
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
