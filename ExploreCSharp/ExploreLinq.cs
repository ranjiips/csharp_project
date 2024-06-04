using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    class Product
    {
        public string ProductName;
        public int Price;
    }

    class StudentMarks
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
        public string Title;
        public int Price;
    }
    class ExploreLinq
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
            bool result = price1List.SequenceEqual(price2List);
            Console.WriteLine($"The give lists are sequence equal {result}");
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
            Console.WriteLine("Square root of {0} is {1}", num, sqrnum(num));

            //Func<int, int> multiple = n => n * num;
            //var result = multiple(10);
            //Console.WriteLine("{0} * {1} is {3}", 10, num, result);
        }
    }
}
