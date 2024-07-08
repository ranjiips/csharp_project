using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class StringOperations
    {
        public void ConcatenateStrings(string str1, string str2)
        {
            Console.WriteLine($"Concatenate two strings: {str1 + str2}");
        }

        public void ReplaceGivenValueInString(string str1, string oldvalue, string newvalue)
        {
            Console.WriteLine($"Before replace the string, original text: {str1}");
            Console.WriteLine($"After replace the string '{oldvalue}' with the string '{newvalue}' is : {str1.Replace(oldvalue, newvalue)}");
        }

        public void TrimSpaces(string values)
        {
            Console.WriteLine($"Value after removed the trailing spaces: '{values.Trim()}'");
        }

        public bool IsStringContains(string str1, string checkValue)
        {
            return str1.ToLower().Contains(checkValue.ToLower());
        }
        public void StringBuilderExamples(string str1, string str2)
        {
            StringBuilder str = new StringBuilder();
            str.Append(str1);
            str.Append(str2);
            Console.WriteLine($"String builder example: {str}");
        }

        public void ImplementExtensionMethodConcepts(string post)
        {
            var shortenedPost = post.Shorten(10);
            Console.WriteLine($"Actual Post: {post}");
            Console.WriteLine($"Shortened Post: {shortenedPost}");            
        }
    }
}
