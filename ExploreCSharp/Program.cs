using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ExploreCSharp.SeleniumWeb;

namespace ExploreCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
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
            ImplementJsonConcepts();
            //ImplementSeleniumConcepts();
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

            linq.SortTheStuduentRecords();
            linq.RemoveDuplicatesFromStringArrayUsingLinq();

            Console.WriteLine("\n***********  Implement LambdaExpressions Concepts***********\n");
            linq.SampleLambdaExpressions(5);
        }

        public static void ImplementCSVFileHandlingConcepts()
        {
            //File Handling Class
            Console.WriteLine("\n***********  Implement CSV File Handling Concepts***********\n");
            string filePath = "C:/Ranjith/Learnings/Projects/itemdetails.csv";
            FileHandlingCSV csvfile = new FileHandlingCSV();
            //csvfile.WriteContentIntoCSV(filePath);
            csvfile.ReadContentFromCSV(filePath);
            csvfile.ReadCSVContentLineByLine(filePath);
            //csvfile.ReadCSVContentLineByLine(filePath, "Car");
            csvfile.ReadCSVContentLineByLine(filePath, "Bus");
        }

        public static void ImplementExcelFileHandlingConcepts()
        {
            //File Handling Class
            Console.WriteLine("\n***********  Implement Excel File Handling Concepts***********\n");
            string filePath = "C:/Ranjith/Learnings/Projects/itemdetails.xlsx";
            FileHandlingExcel excelfile = new FileHandlingExcel(filePath,1);
            Console.WriteLine($"Excel content: {excelfile.ReadCell(0, 0)}");
            excelfile.WriteGivenCell("B10","SampleText");
            excelfile.ReadGivenCell("B10");
            Console.WriteLine("-------------------------------------------------\n");
            excelfile.WriteGivenCellRange("B2:B6", "SampleText");
            excelfile.ReadCellRange();
            Console.WriteLine("-------------------------------------------------\n");
            excelfile.WriteMulitpleCells();
            excelfile.ReadCellRange();
            //excelfile.SaveWorkboox();
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
            gc.RemoveDuplicatesFromStringArrayList();
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

        public static void ImplementRestAPIMethods()
        {
            Console.WriteLine("\n***********  Implement Rest API Methods***********\n");
            string apiurl = "https://rahulshettyacademy.com";
            string getbookapiurl = "/Library/GetBook.php";
            string queryParam = $"{getbookapiurl}?ID=AABD445";
            HandleAPIs apiObj = new HandleAPIs(apiurl);
            apiObj.DeleteBookAPI("/Library/DeleteBook.php", "AABD445");
            apiObj.PostRequestAPI("/Library/Addbook.php");
            apiObj.GetRequestAPI(queryParam);
        }

        public static void ImplementJsonConcepts()
        {
            Console.WriteLine("\n***********  Implement Json Methods***********\n");
            int jsonCount = Pages.FileHandlingJSON.GetValuesUsingIndex();
            int jsonObjCount = Pages.FileHandlingJSON.GetValuesUsingValueMethod();
        }

        public static void ImplementSeleniumConcepts()
        {
            Console.WriteLine("\n***********  Implement Selenium Web Interaction Concepts***********\n");
            string baseurl = "https://the-internet.herokuapp.com/";

            Pages.SeleniumLoginLogoutActions.NavigateToURL(baseurl);

            //Pages.SeleniumLoginLogoutActions.LoadPageByText("Form Authentication");
            //Pages.SeleniumLoginLogoutActions.VerifyPageTitle("Login Page", Pages.SeleniumLoginLogoutActions.loginpageHeaderLocator);
            //Pages.SeleniumLoginLogoutActions.LoginWithValidCredentials("tomsmith", "SuperSecretPassword!");
            //Pages.SeleniumLoginLogoutActions.VerifyMessage("You logged into a secure area");
            //Pages.SeleniumLoginLogoutActions.LogoutAction();
            //Pages.SeleniumLoginLogoutActions.VerifyMessage("You logged out of the secure area");
            //Pages.SeleniumLoginLogoutActions.BackToMainPage();

            //Pages.SeleniumJavaScriptActions.ClickLinkByText("Basic Auth");
            //Pages.SeleniumJavaScriptActions.EnterCredentialsInJSPopup();
            //Pages.SeleniumJavaScriptActions.VerifyJavaScriptLoginMessage();
            //Pages.SeleniumJavaScriptActions.BackToMainPage();

            //Pages.SeleniumFormActions.LoadPageByText("Checkboxes");
            //Pages.SeleniumFormActions.VerifyPageTitle("Checkboxes", Pages.SeleniumFormActions.checkboxPageHeaderLocator);
            //Pages.SeleniumFormActions.UnselectAndSelectCheckbox();
            //Pages.SeleniumFormActions.BackToMainPage();

            //Pages.SeleniumMouseActions.LoadPageByText("Drag and Drop");
            //Pages.SeleniumMouseActions.VerifyPageTitle("Drag and Drop", Pages.SeleniumFormActions.checkboxPageHeaderLocator);
            //Pages.SeleniumMouseActions.DragAndDropAction();
            //Pages.SeleniumFormActions.BackToMainPage();

            //Pages.SeleniumFrames.LoadPageByText("Frames");
            //Pages.SeleniumFrames.VerifyPageTitle("Frames", Pages.SeleniumFormActions.checkboxPageHeaderLocator);
            //Pages.SeleniumFrames.LoadPageByText("Nested Frames");
            //Pages.SeleniumFrames.SwitchToFrameAction();
            //Pages.SeleniumFormActions.BackToMainPage();

            Pages.SeleniumFrames.LoadPageByText("Multiple Windows");
            Pages.SeleniumFrames.VerifyPageTitle("Opening a new window", Pages.SeleniumFormActions.checkboxPageHeaderLocator);
            Pages.SeleniumMulitpleWindows.OpenChildWindow("New Window");
            Pages.SeleniumFormActions.BackToMainPage();


            Pages.SeleniumLoginLogoutActions.CloseBrowser();
        }
    }
}
