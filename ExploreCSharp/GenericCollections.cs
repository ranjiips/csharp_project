using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    class GenericCollections
    {
        class Products
        {
            public string ItemName;
            public float ItemPrice;
        }
        public void UsingDictionary()
        {
            Console.WriteLine("\n***********  Dictionary Concepts***********\n");

            Dictionary<int, string> dicValues = new Dictionary<int, string>();
            dicValues.Add(1,"Ranjith");
            dicValues.Add(2,"Kumat");
            dicValues.Add(3,"Subramaniam");

            foreach(KeyValuePair<int, string> element in dicValues)
            {
                Console.WriteLine("Key:- {0} and Value:- {1}", element.Key, element.Value);
            }
        }

        public void UsingList()
        {
            Console.WriteLine("\n***********  List Concepts***********\n");
            List<int> listvalues = new List<int>();
            listvalues.Add(5);
            listvalues.Add(7);
            listvalues.Add(3);
            listvalues.Append(6);

            foreach(int values in listvalues)
            {
                Console.WriteLine(values);
            }

            List<Products> productDetails = new List<Products>()
            {
                new Products { ItemName="Nokia 110", ItemPrice = 1550},
                new Products { ItemName="Samsung Guru", ItemPrice = 1350},
                new Products { ItemName="Nokia 320", ItemPrice = 1450},
                new Products { ItemName="Samsung 3240", ItemPrice = 1800}
            };
            Console.WriteLine($"\nMobile price greater than 1500 rs are: ");
            IEnumerable<Products> details = from mobile in productDetails where mobile.ItemPrice >= 1500 select mobile;
            foreach(var val in details)
            {
                Console.WriteLine(string.Format("{0} - {1}", val.ItemName, val.ItemPrice));
            }

        }

        public void UsingSortedList()
        {

        }

        public void UsingArrayList()
        {

        }

        public void UsingHashTable()
        {

        }

        public void UsingStack()
        {
            Console.WriteLine("\n***********  Stack Concepts***********\n");
            Stack<int> objStack = new Stack<int>();
            objStack.Push(1);
            objStack.Push(2);
            objStack.Push(3);
            // Display first value from Stack
            Console.WriteLine("First Get Value from Stack: {0}", objStack.Pop());
        }

        public void UsingQueue()
        {
            Console.WriteLine("\n***********  Queue Concepts***********\n");
            Queue<int> objQueue = new Queue<int>();
            objQueue.Enqueue(1);
            objQueue.Enqueue(2);
            objQueue.Enqueue(3);
            // Display first value from Stack
            Console.WriteLine("First Get Value from Queue: {0}", objQueue.Dequeue());
        }
    }
}
