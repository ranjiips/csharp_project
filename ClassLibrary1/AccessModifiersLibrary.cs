using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class AccessModifiersLibrary
    {
        private void Demo()
        {
            Console.WriteLine("Calling the Private Demo method from Private Method");
            PrivateDemo();
        }

        private void PrivateDemo()
        {
            Console.WriteLine("Logging from the Private Demo method. Actual Implementation");
        }

        private protected void PrivateProtectedDemo()
        {
            Console.WriteLine("Logging from the Private Protected Demo method. Actual Implementation");
        }

        protected void ProtectedDemo()
        {
            Console.WriteLine("Logging from the Protected Demo method. Actual Implementation");
        }

        protected internal void ProtectedInternalDemo()
        {
            Console.WriteLine("Logging from the Protected Internal Demo method. Actual Implementation");
        }

        internal void InternalDemo()
        {
            Console.WriteLine("Logging from the Internal Demo method. Actual Implementation");
        }

        public void PublicDemo()
        {
            Console.WriteLine("Calling the Private Demo method from Public method");
            Demo();
        }

        public void CheckPalindrome(string name)
        {
        
            char[] arr = name.ToCharArray();
            int arrLength = name.Length;
            string reversedString = "";
            for(int i=arrLength-1;i>=0;i--)
            {
                char val = arr[i];
                Console.WriteLine(val);
                reversedString = reversedString + val;
               
            }
            if (reversedString.Equals(name))
                Console.WriteLine($"The given name {name} is palindrome");
            else
                Console.WriteLine($"The given name {name} is not a palindrome");
 
        }

        public void PrintDuplicateCharacter()
        {
            string name = "Raanjiith";
            char[] arr = name.ToCharArray();
            int arrLength = arr.Length;
            List<char> duplicate = new List<char>();
            
            for(int i=0;i<arrLength;i++)
            {
                for (int j=i+1;j<arrLength-1;j++)
                {
                    
                    if (arr[i] == arr[j])
                    {
                        duplicate.Add(arr[j]);

                    }

                }              
                
            }
            string combinedString = string.Join(",", duplicate);
            Console.WriteLine("Duplicate values are " +combinedString);

        }

        public void RemoveDuplicateCharactersFromString(String name)
        {
            string newName = "";
            for(int i=0;i<name.Length;i++)
            {
                if(!newName.Contains(name[i]))
                {
                    newName = newName + name[i];
                }
            }
          
            Console.WriteLine("Removed duplicate string is" + newName);
        }

        public void RemoveDuplicateStringFromAStrings(string name)
        {
            var names = name.Split(",").ToList();
            var distinctNames = names.Distinct();
            Console.WriteLine("Removed duplicate string from the given strings" + string.Join(",",distinctNames));
        }

        public void CheckElementInListUsingLinq(String countryName)
        {
            List<string> countryList = new List<string>
            {
                "USA","Japan","India","UK","Malaysia"

            };

            bool flag = countryList.Any(e => e.Equals(countryName.Trim()));
            Console.WriteLine($"Given country {countryName} is available in the country list " + flag);
                
        }

        public void GetStringContains()
        {
            List<string> nameList = new List<string>
            {
                "Ranjith Kumar",
                "Sampath Kumar",
                "Kalaiselvan",
                "Kishore Kumar",
                "Vikram",
                "Venkat",
                "Ramesh Kumar"
            };

            var matchedNames = nameList.Where(e => e.Contains("Kumar")).Select(r => r).ToList();
            Console.WriteLine("The matched names are " + string.Join(",", matchedNames));
        }
    }
}
