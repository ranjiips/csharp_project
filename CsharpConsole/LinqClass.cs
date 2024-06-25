using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsole
{
    public class MobileInfo
    {
        public string MobileName { get; set; }
        public int MobilePrice { get; set; }
        public double SAR { get; set; }
    }

    public class LinqClass
    {
        
        //int numberlist = {100,201,400,700,157,50,900, 138}
        public List<int> numbers = new List<int>() { 100, 201, 400, 700, 157, 50, 900, 138 };
        public List<int> numbers2 = new List<int>() { 200, 207, 408, 760, 177, 45, 908, 108 };

        //mobile:nokia price:1000
        //mobile:samsung price:2000
        //mobile:oppo price:2500
        //mobile:iphone price:10000
        List<MobileInfo> mobileDetails = new List<MobileInfo>
        {
            new MobileInfo{ MobileName="Nokia", MobilePrice= 2000, SAR=1.6},
            new MobileInfo{ MobileName="Samsung", MobilePrice= 1500, SAR=2.2},
            new MobileInfo{ MobileName="iPhone", MobilePrice= 30000, SAR=1.5},
            new MobileInfo{ MobileName="Oppo", MobilePrice= 7000, SAR=1.7},
            new MobileInfo{ MobileName="Lava", MobilePrice= 1000, SAR=0.6},
            new MobileInfo{ MobileName="Poco", MobilePrice= 9200, SAR=1.2},
            new MobileInfo{ MobileName="Redmi", MobilePrice= 8500, SAR=2.4},
            new MobileInfo{ MobileName="Moto", MobilePrice= 1000, SAR=0.9},
            new MobileInfo{ MobileName="OnePlus", MobilePrice= 2000, SAR=1.1}
        };

        //sort the numbers into descending order
        public void SortTheNumbers()
        {   
            var num = numbers.OrderByDescending(e=>e);
            PrintValues(num);
        }

        //Reverse the list
        public void ReverseTheNumberList()
        {
            var num = numbers.AsEnumerable().Reverse();
            PrintValues(num);
        }

        //maximum value
        public void GetMinimumValue()
        {
            var minvalue = numbers.Min();
            Console.WriteLine($"Minimum value: {minvalue}");
        }
        //minimum value
        public void GetMaximumValue()
        {
            var maxvalue = numbers.Max();
            Console.WriteLine($"Maximum value: {maxvalue}");
        }

        //count of the list
        public void GetListCount()
        {
            int count = numbers.Count();
            Console.WriteLine($"List Count: {count}");
        }

        //get even numbers
        public void GetEvenNumbersFromTheList()
        {
            var evenNumbers = from num in numbers where num%2==0 select num;
            Console.WriteLine("Even Numbers with Query String");
            PrintValues(evenNumbers);

            IEnumerable<int> evenNums = numbers.Where(e => e % 2 == 0).Select(e=>e);
            Console.WriteLine("Even Numbers with Linq");
            PrintValues(evenNums);
        }

        //find the value in the 'n' position
        public void GetvalueFromNthPoistion(int position)
        {
            var positionvalue = numbers.ElementAt(position-1);
            Console.WriteLine($"Numbers in the position {position} is : {positionvalue}");
        }

        public void GetTheHighestNumberBasedOnGivenPosition(int position)
        {
            var sortList = numbers.OrderByDescending(e=>e);
            int value = sortList.ElementAt(position - 1);
            Console.WriteLine($"Numbers in the position {position} is : {value}");
        }

        public void GetMobileByPrice(int value)
        {
            var mobilelist = from mob in mobileDetails where mob.MobilePrice <= value select mob;
            var mobileListDetails = mobileDetails.Where(e => e.MobilePrice >= value).Select(e => e.MobileName);

            foreach (var x in mobilelist)
            {
                Console.WriteLine($"Mobile Name: {x.MobileName} \t Mobile Price: {x.MobilePrice}");
            }

            foreach (var x in mobileListDetails)
            {
                Console.WriteLine($"Mobile Name: {x}");
            }
        }

        public void SortMobileByPriceAndSAR()
        {
            Console.WriteLine("======================== Mobile details before sorting ========================");
            foreach (var x in mobileDetails)
            {
                Console.WriteLine($"Mobile Name: {x.MobileName} \t Mobile Price: {x.MobilePrice} \t SAR Value: {x.SAR}");
            }
            var sortedMobileList = mobileDetails.OrderByDescending(e=>e.MobilePrice).ThenBy(e=>e.SAR);
            Console.WriteLine("======================== Mobile details After sorting ========================");
            foreach (var x in sortedMobileList)
            {
                Console.WriteLine($"Mobile Name: {x.MobileName} \t Mobile Price: {x.MobilePrice} \t SAR Value: {x.SAR}");
            }
        }

        public void PrintValues(IEnumerable<int> values)
        {
            foreach (int i in values)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine("\n");
        }

        public void JoinNumberList()
        {
            var finalList = numbers.Concat(numbers2);
        }
    }
}
