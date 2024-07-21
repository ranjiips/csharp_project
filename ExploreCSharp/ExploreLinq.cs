﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    class Product
    {
        public string ProductName;
        public int Price;
    }

    public class StudentMarks
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Class { get; set; }
        public int Tamil { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
    public class ExploreLinq
    {
        List<Product> productdetails = new List<Product>
        {
            new Product{ ProductName="iPhone", Price=35000},
            new Product{ ProductName="Nokia", Price=10000},
            new Product{ ProductName="OnePlus", Price=30000},
            new Product{ ProductName="Motorola", Price=20000},
            new Product{ ProductName="Lava", Price=8000},
            new Product{ ProductName="Samsung", Price=25000},
            new Product{ ProductName="Redmi", Price=12000}
        };

        List<StudentMarks> StudentDetails = new List<StudentMarks>
        {
            new StudentMarks{ StudentID=101, StudentName="Karthik", Class=8, Tamil=87, English=76, Maths=89, Science=92, Social=80 },
            new StudentMarks{ StudentID=102, StudentName="Kannan", Class=8, Tamil=67, English=67, Maths=90, Science=68, Social=70 },
            new StudentMarks{ StudentID=103, StudentName="Arjun", Class=7, Tamil=77, English=66, Maths=55, Science=75, Social=60 },
            new StudentMarks{ StudentID=104, StudentName="Sathish", Class=8, Tamil=89, English=86, Maths=64, Science=90, Social=75 },
            new StudentMarks{ StudentID=105, StudentName="Ramya", Class=7, Tamil=50, English=90, Maths=72, Science=65, Social=68 },
            new StudentMarks{ StudentID=106, StudentName="Bakya", Class=8, Tamil=65, English=88, Maths=65, Science=72, Social=67 },
            new StudentMarks{ StudentID=107, StudentName="Priya", Class=7, Tamil=93, English=54, Maths=89, Science=68, Social=76 },
            new StudentMarks{ StudentID=108, StudentName="Rahul", Class=8, Tamil=35, English=73, Maths=30, Science=65, Social=46 },
            new StudentMarks{ StudentID=109, StudentName="Gomathi", Class=6, Tamil=87, English=72, Maths=60, Science=88, Social=71 },
            new StudentMarks{ StudentID=110, StudentName="Sarath", Class=6, Tamil=66, English=88, Maths=40, Science=61, Social=57 }
        };

        List<StudentMarks> ExtendedStudentDetails = new List<StudentMarks>
        {
            new StudentMarks{ StudentID=101, StudentName="Sunil", Class=8, Tamil=87, English=76, Maths=89, Science=92, Social=80 },
            new StudentMarks{ StudentID=102, StudentName="Prasath", Class=8, Tamil=67, English=67, Maths=90, Science=68, Social=70 },
            new StudentMarks{ StudentID=103, StudentName="Kathir", Class=7, Tamil=77, English=66, Maths=55, Science=75, Social=60 },
            new StudentMarks{ StudentID=104, StudentName="Archana", Class=8, Tamil=89, English=86, Maths=64, Science=90, Social=75 },
            new StudentMarks{ StudentID=105, StudentName="Ananya", Class=7, Tamil=50, English=90, Maths=72, Science=65, Social=68 },
            new StudentMarks{ StudentID=106, StudentName="Divya", Class=8, Tamil=65, English=88, Maths=65, Science=72, Social=67 },
            new StudentMarks{ StudentID=107, StudentName="Sundar", Class=7, Tamil=93, English=54, Maths=89, Science=68, Social=76 }
        };


        List<Book> BookDetails()
        {
            return new List<Book>
            {
                new Book() { Title = "C#", Price=456},
                new Book() { Title = "Java", Price=532},
                new Book() { Title = "Python", Price=297},
                new Book() { Title = "SQL", Price=154},
                new Book() { Title = "Selenium", Price=188}
            };
        }

        public IEnumerable<Book> GetBookDetails()
        {
            return new List<Book>
            {   
                new Book() { Title = "Python", Price=297},
                new Book() { Title = "SQL", Price=154},
                new Book() { Title = "Java", Price=532},
                new Book() { Title = "Selenium", Price=188},
                new Book() { Title = "C#", Price=456}
            };
        }

        public void QueryTheProductDetails(int value)
        {
            IEnumerable<Product> details = from mobile in productdetails
                                           where mobile.Price >= value
                                           select mobile;
            Console.WriteLine($"\nMobile price greater than {value}'s are: ");

            foreach (var q in details)
            {
                Console.WriteLine(string.Format("{0} - {1}", q.ProductName, q.Price ));
            }

            //Mobile price greater than 20000's are: System.Linq.Enumerable+WhereSelectListIterator`2[ExploreCSharp.Product,System.String]
        }

        public void FindMobilePriceFromList(int position)
        {            
            var itemDetails = productdetails.OrderByDescending(e => e.Price);
            var itemInGivenPosition = itemDetails.ElementAt(position - 1);
            Console.WriteLine($"The {position} largest product from the given list " + itemInGivenPosition.ProductName + " and the Price is " + itemInGivenPosition.Price);

            var mobilePrice = productdetails.Where(e => e.ProductName == "Motorola").Select(e => e.Price).FirstOrDefault();
            Console.WriteLine($"Motorola Mobile price is {mobilePrice}");
        }

        public void FindMobilePriceFromArrayList(int position)
        {
            string[] product = { "iPhone 11", "galaxy S23", "Pixel 4", "iPhone 8", "Oppo", "Nord", "Lava", "Max" };
            int[] price = { 700, 600, 800, 300, 400, 350, 200, 150 };
            List<string> ProductName = product.ToList();
            List<int> ProductPrice = price.ToList();

            var sortedPrice = ProductPrice.OrderByDescending(e => e);
            var findPosition = ProductPrice.FindIndex(e => e.Equals(sortedPrice.ElementAt(position - 1)));
            string name = ProductName.ElementAt(findPosition);
            bool pricestatus = ProductPrice.All(e => e > 200);
            Console.WriteLine($"Is all the Product price greater than 100: {pricestatus}");

            Console.WriteLine($"The {position} largest product from the given list is " + name + " and its price is " + sortedPrice.ElementAt(position - 1));
        }

        public void IsTwoListSequenceEqual()
        {
            int[] price1 = { 700, 600, 800, 300, 400, 350, 200, 150 };
            int[] price2 = { 700, 350, 800, 300, 400, 600, 200, 150 };
            List<int> price1List = price1.ToList();
            List<int> price2List = price2.ToList();

            var finalpriceList = price1List.Concat(price2List).ToList();
            Console.WriteLine($"Concatenated price list values are: {string.Join(" ", finalpriceList)}");

            bool result = price1List.SequenceEqual(price2List);
            Console.WriteLine($"The give lists are sequence equal {result}");
            
            var maxprice = finalpriceList.Max(e => e);
            Console.WriteLine($"Maximum price is {maxprice}");

            var minprice = finalpriceList.Min(e=>e);
            Console.WriteLine($"Minimum price is {minprice}");

            var priceSum = finalpriceList.Sum(e=>e);
            Console.WriteLine($"Price List sum is {priceSum}");

            var averagePrice = finalpriceList.Average(e=>e);
            Console.WriteLine($"Price List average is {averagePrice}");

            var priceCount = finalpriceList.Count();
            Console.WriteLine($"Price count is {priceCount}");
        }

        public void FindPatternMatch()
        {
            string[] words = { "floor", "flow", "flower", "flaws", "float" };
            List<string> WordList = words.ToList();
        }

        public void GetEvenAndOddNumbersFromList(int[] numbers)
        {
            var evenQuery = from num in numbers where (num % 2) == 0 select num;
            Console.Write("\nThe even numbers are: ");

            foreach (int i in evenQuery)
            {
                Console.Write($" {i}  ");
            }

            IEnumerable<int> oddMethod = numbers.Where(num => num % 2 != 0);
            Console.Write("\nThe Odd numbers are: ");
            foreach (int i in oddMethod)
            {
                Console.Write($" {i}  ");
            }

        }

        public void SortTheStuduentRecords()
        {
            string print = "-";

            var sortClass = StudentDetails.OrderBy(c => c.Class);
            PrintDetails(sortClass);            
            Console.WriteLine(print.RepeatValues(30));
            var sortclasstamil = StudentDetails.OrderBy(c => c.Class).ThenBy(c => c.Tamil);
            PrintDetails(sortclasstamil);
            Console.WriteLine(print.RepeatValues(30));
            var sortall = StudentDetails.OrderBy(c => c.Class).ThenBy(c => c.Tamil)
                .ThenBy(c => c.English).ThenBy(c => c.Maths).ThenBy(c => c.Science)
                .ThenBy(c => c.Social);
            PrintDetails(sortall);
        }

        

        public void PrintDetails(IEnumerable<StudentMarks> values)
        {
            foreach (StudentMarks s in values)
                Console.WriteLine($"{s.StudentName} - {s.Class} - {s.Tamil} - {s.English} - {s.Maths} - {s.Science} - {s.Social}");

        }

        public void QueryTheStudentRecord(int conditions)
        {
            IEnumerable<StudentMarks> record = from stu in StudentDetails
                                               where stu.Class == conditions
                                               select stu;
            Console.WriteLine($"Student records for the class: {conditions} are ");

            foreach (var val in record)
            {
                Console.WriteLine($"Student Name: {val.StudentName}, Class: {val.Class}, Tamil: {val.Tamil}, English: {val.English}, " +
                    $"Maths: {val.Maths}, Science: {val.Science}, Social: {val.Social}");
            }
        }

        public void QueryTheStudentRecord(int stuclass, int englishmark)
        {
            IEnumerable<StudentMarks> record = from stu in StudentDetails
                                               where stu.Class == stuclass && stu.English >= englishmark
                                               select stu;
            Console.WriteLine($"Student records for the class: {stuclass} who scored more than {englishmark} in English are ");

            foreach (var val in record)
            {
                Console.WriteLine($"Student Name: {val.StudentName}, Class: {val.Class}, Tamil: {val.Tamil}, English: {val.English}, " +
                    $"Maths: {val.Maths}, Science: {val.Science}, Social: {val.Social}");
            }
        }
        public void SampleLambdaExpressions(int num)
        {
            //int num = 5;
            Func<int, int> sqrnum = num => num * num;
            Console.WriteLine("\nSquare root of {0} is {1}", num, sqrnum(num));

            Console.WriteLine("\n-------- Before Lambda Expression --------");
            var cheapBooks = BookDetails().FindAll(IsCheaper);
            Console.WriteLine("Book price Greater than 200 are:");
            PrintBookDetails(cheapBooks);

            Console.WriteLine("-------- With Lambda Expression --------");
            var cheapbooks = BookDetails().FindAll(b => b.Price < 200);
            Console.WriteLine("Book price less than 200 are:");
            PrintBookDetails(cheapbooks);
        }

        static bool IsCheaper(Book book)
        {
            return book.Price > 200;
        }

        public void LinQExpressionExamples()
        {
            Console.WriteLine("\n-------- Before LinQ Expression --------");
            var books = GetBookDetails();
            var cheapBooks = new List<Book>();

            foreach (var book in books)
            {
                if(book.Price < 200)
                    cheapBooks.Add(book);
            }
            Console.WriteLine("Book price less than 200 are:");
            PrintBookDetails(cheapBooks);

            Console.WriteLine("-------- With LinQ Expression - OrderBy --------");
            Console.WriteLine("Book price greater than 200 are:");
            var cheapbooks = GetBookDetails().Where(b=>b.Price>200).OrderBy(b=>b.Title);
            PrintBookDetails(cheapbooks);

            Console.WriteLine("-------- With LinQ Expression - LINQ Extension Methods --------");
            var getbooks = GetBookDetails()
                                        .Where(b => b.Price > 200)
                                        .OrderBy(b => b.Title)
                                        .Select(b=>b.Title);
            foreach (var book in getbooks)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("-------- With LinQ Expression - LINQ Query Operators --------");
            var getcheaperbooks = from b in GetBookDetails()
                                  where b.Price > 200
                                  orderby b.Title
                                  select b;
            PrintBookDetails(getcheaperbooks);

            Console.WriteLine("\n-------- LinQ Extension Methods --------");
            Console.WriteLine("---------------FirstOrDefault------------------");
            var javabook = GetBookDetails().FirstOrDefault(b => b.Title == "Java");
            Console.WriteLine(javabook.Title + " - Rs." + javabook.Price);
            Console.WriteLine("-----------------Max and Min book Price----------------");
            var maxprice = GetBookDetails().Max(b => b.Price);
            var minprice = GetBookDetails().Min(b => b.Price);
            Console.WriteLine(maxprice);
            Console.WriteLine(minprice);
            Console.WriteLine("---------Skip 2 books-------Take next 3 books----------------");
            var skipbook = GetBookDetails().Skip(2).Take(3);
            PrintBookDetails(skipbook);
            Console.WriteLine("-------------Book Count-----------------");
            var bookcount = GetBookDetails().Count();
            Console.WriteLine(bookcount);
        }

        public void PrintBookDetails(IEnumerable<Book> cheapBooks)
        {
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title + " - Rs." + book.Price);
            }
        }

        public void RemoveDuplicatesFromStringArrayUsingLinq()
        {
            Console.WriteLine("\n***********  Remove Duplicates from Array ***********\n");
            string[] sArray = { "a", "b", "b", "c", "c", "d", "e", "f", "f" };
            Console.WriteLine("\nOriginal Array List:");
            for (int i = 0; i < sArray.Length; i++)
            {
                Console.Write(sArray[i]);
            }
            Console.WriteLine("\nArray after remove the duplicates:");
            var sNew = sArray.Distinct().ToArray();
            for (int i = 0; i < sNew.Length; i++)
            {
                Console.Write(sNew[i]);
            }
        }

        public void GetValuesBasedOnType()
        {
            Console.WriteLine("\n***********  Get Values Based On Type using - OfType() ***********\n");
            ArrayList list = new ArrayList() { "a", "b", 2,0,"c", true, 5.4, 3.67, 22, "d", false, "h"};

            Console.Write("Actual Values: ");
            foreach (var s in list)
                Console.Write(s + " ");
            Console.WriteLine();

            var getStringValues = from s in list.OfType<string>() select s;
            Console.Write("String Type: ");
            foreach (var s in getStringValues)
                Console.Write(s+" ");
            Console.WriteLine();

            var getIntegerValues = from s in list.OfType<int>() select s;
            Console.Write("Integer Type: ");
            foreach (var s in getIntegerValues)
                Console.Write(s + " ");
            Console.WriteLine();

            var getBooleanValues = from s in list.OfType<bool>() select s;
            Console.Write("Boolean Type: ");
            foreach (var s in getBooleanValues)
                Console.Write(s + " ");
            Console.WriteLine();

            var getDecimalValues = from s in list.OfType<double>() select s;
            Console.Write("Decimal Type: ");
            foreach (var s in getDecimalValues)
                Console.Write(s + " ");
            Console.WriteLine();
        }

        public void OrderByFunction()
        {
            Console.WriteLine("\n***********  OrderBy, ThenBy ***********\n");
            var afterSorting = StudentDetails.OrderBy(b => b.Class).ThenBy(b=>b.Tamil).ThenBy(b=>b.Maths).ThenByDescending(b=>b.StudentID);
            foreach(var i in afterSorting)
            {
                Console.WriteLine(i.StudentID +" " +i.StudentName + " " + i.Class + " " + i.Tamil + " " + i.English + " " 
                    + i.Maths + " " + i.Science + " " + i.Social);
            }
        }

        public void GroupByFunction()
        {
            Console.WriteLine("\n***********  ToLookup - Method Syntax ***********\n");

            var lookupExpression = StudentDetails.ToLookup(s => s.Class);
            foreach (var x in lookupExpression)
            {
                Console.WriteLine($"Lookup Key - Class: {x.Key}");
                foreach (var i in x)
                    Console.WriteLine(i.StudentID + " " + i.StudentName);
            }

            Console.WriteLine("\n***********  GroupBy - Method Syntax ***********\n");
            var groupbyMethod = StudentDetails.GroupBy(s => s.Class);
            foreach (var x in groupbyMethod)
            {
                Console.WriteLine($"GroupBy Key - Class: {x.Key}");
                foreach (var i in x)
                    Console.WriteLine(i.StudentID + " " + i.StudentName);
            }

            Console.WriteLine("\n***********  GroupBy - Query Expression ***********\n");
            var groupbyExpression = from s in StudentDetails group s by s.Class;
            foreach (var x in groupbyExpression)
            {
                Console.WriteLine($"GroupBy Key - Class: {x.Key}");
                foreach (var i in x)
                    Console.WriteLine(i.StudentID + " " + i.StudentName);
            }
        }

        public void JoinFunctions()
        {
            Console.WriteLine("\n***********  Join Operations ***********\n");
            var innerJoin = StudentDetails.Join(ExtendedStudentDetails, 
                s=>s.StudentID, 
                y=>y.StudentID, 
                (s,y)=>new { StudentID = s.StudentID, StudentName = y.StudentName});
            foreach (var i in innerJoin)
                Console.WriteLine(i.StudentID + " " + i.StudentName);
        }

        public void GetIntegerFromTheString()
        {
            Console.WriteLine("\n***********  Fetch Integer from the given string - Using Method Syntax ***********\n");
            string value = "ed@#12.45$%23";

            string integerValues = new string(value.Where(Char.IsDigit).ToArray());
            Console.WriteLine(integerValues);
        }

        public void FetchTheIntegerValues()
        {
            Console.WriteLine("\n***********  Fetch Integer from the given string - using Regular expression ***********\n");
            string somevalue = "ed@#12.45$%23";
            string[] intArray = Regex.Split(somevalue, "[^0-9]+");
            foreach(var i in intArray)
                Console.Write(i.ToString());
        }
    }
}
