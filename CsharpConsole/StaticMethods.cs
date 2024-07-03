using AccessModifiersClasses;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsole
{
    public  class StaticMethods
    {
        public static void UseParams()
        {
            var calc = new Calculator();
            Console.WriteLine("Sum of the given numbers: {0}", calc.AddNumbers(1, 2));
            Console.WriteLine("Sum of the given numbers: {0}", calc.AddNumbers(1, 2, 3));
            Console.WriteLine("Sum of the given numbers: {0}", calc.AddNumbers(1, 2, 3, 4));
            Console.WriteLine("Sum of the given numbers: {0}", calc.AddNumbers(1, 2, 3, 4, 5));
        }

        public static void UseOutModifier()
        {
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine("Conversion success: {0}", number);
            else
                Console.WriteLine("Conversion failed");
        }

        public static void UseRefModifier(ref int a)
        {
            a -= 5;
        }

        public static void UsingRefOutModifier()
        {
            //Divide 2 numbers and return quotient and remainder using REF and OUT keyword
            var calc = new Calculator();
            int dividend = 10;
            int divisor = 3;
            calc.DivedeTwoNumbers(ref dividend, ref divisor, out int quotient, out int remainder);
            Console.WriteLine("Divide {0} by {1} return Quotient = {2}; Remainder = {3}", dividend, divisor, quotient, remainder);
        }

        public static void DataTypes()
        {
            string a = "Hello";
            string b = "World!";
            int num1 = 5;
            int num2 = 6;
            int num3 = num1 + num2;
            Console.WriteLine("{0} {1}", a, b);
            Console.WriteLine("Sum of the numbers {0} and {1} is {2}", num1, num2, num3);
        }

        public static void ControlStatments()
        {
            //read character from console
            //Console.WriteLine("Enter two integers");
            //int num1, num2;
            //int num1 = (int)Console.Read();
            //int num2 = (int)Console.Read();
            int num1 = 10;
            int num2 = 6;
            if (num1 > num2)
                Console.WriteLine("IF block: {0} is greater than {1}", num1, num2);
            else
                Console.WriteLine("ELSE block: {0} is greater than {1}", num2, num1);
        }

        public static void HandlePersonClass()
        {
            //Handle Person Class
            var person = new Person();
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            person.Name = "John";
            person.Introduce("Katy");

            var person1 = Person.Parse(20);
            person1.IntroduceAge("Katy");

            //using Object initializer, without calling the consutructors initializing the fields
            var person2 = new Person
            {
                Name = "Ranjith",
                Age = 35
            };
            person2.IntroduceAge("John");
        }

        public static void HandleCustomerClass()
        {
            //Handle Customer Class
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            //Handle Orders Class
            var order = new Order();
            customer.Orders.Add(order);

            //constructors, object initializers
            var Customer = new Customer(1, "Ranjith");
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine("Orders count: {0}", customer.Orders.Count);
        }

        public static void HandleOverloading()
        {
            //Handle point class - overloading
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            Console.WriteLine("Point is at {0} and {1}", point.X, point.Y);

            point.Move(100, 200);
            Console.WriteLine("Point is at {0} and {1}", point.X, point.Y);
        }

        public static void HandleAccessModifiers()
        {
            //Trying to validate the Access modifiers
            Console.WriteLine("====================================");
            Console.WriteLine("Logging from the Class 1");
            Console.WriteLine("====================================");
            AccessModifiersLibrary obj = new AccessModifiersLibrary();
            obj.PublicDemo();
            obj.CheckPalindrome("12321");
            obj.PrintDuplicateCharacter();
            obj.RemoveDuplicateCharactersFromString("KalaiSelvan");
            obj.RemoveDuplicateStringFromAStrings("Apple,Mango,Apple,Banana,Orange,Mango");
            obj.CheckElementInListUsingLinq("Dubai");
            obj.GetStringContains();

            Console.WriteLine("====================================");
            Console.WriteLine("Logging from the Class 2");
            Console.WriteLine("====================================");
            DemoInternal obj1 = new DemoInternal();
            obj1.MakeDemoCalls();

            Console.WriteLine("====================================");
            Console.WriteLine("Logging from the Class 3");
            Console.WriteLine("====================================");
            DemoInheritance obj2 = new DemoInheritance();
            obj2.Test();

            EmployeeDetails emp = new EmployeeDetails();
            emp.GetEmployeeDetails();
        }

        public static void HandleStringManipulations()
        { 
            StringManipulations str = new StringManipulations();
            str.SwapAlternateLettersInStrings("ABCDEFGHIJ");
            str.FindThirdrdLargestNumberFromList(4);
            str.GetRequestedHighestItemusing2Lists(1);
            str.GetRequestedHighestItemusing2Lists(2);
            str.GetRequestedHighestItemusing2Lists(3);
            str.GetRequestedHighestItemusing2Lists(4);
            Console.WriteLine("====================================");

            str.GetPatternMatch();
            str.GetStringPattern("fla");
            str.GetTheOccuranceOfTheGivenStartingCharater();
        }

        public static void Handle_API_Methods()
        {
            HandleApiClass api = new HandleApiClass();            
            api.PostAPIMethod();
            api.GetAPIMethod();
        }

        public static void HandleCollections()
        {
            HandleCollections obj = new HandleCollections();
            obj.ListManipulation();
        }

        public static void SampleClassImplementation()
        {
            SampleClass sc = new SampleClass(6,4);
            sc.MulitpleTwoNumbers();
            sc.AddTwoNumbers();
        }

    }
}
