using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExensions
    {
        public static string Shorten(this string str, int numofwords)
        {
            if (numofwords <= 0)
            {
                throw new ArgumentOutOfRangeException("number of words should be greater than Zero");
            }

            var words = str.Split(' ');
            if (words.Length <= numofwords )
            {
                return str;
            }
            return string.Join(" ", words.Take(numofwords)) + "...";
        }

        public static string RepeatValues(this string text, uint n)
        {
            return string.Concat(Enumerable.Repeat(text, (int)n));
        }
    }
}
