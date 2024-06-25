using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsole
{
    public class HandleCollections
    {
        public void ListManipulation()
        {
            List<string> Country = new List<string>();
            Country.Add("India");
            Country.Add("China");
            Country.Add("Japan");
            Country.Add("Russia");

            foreach (string s in Country)
            {
                Console.WriteLine(s);
            }

            Country.Insert(3,"Australia");
            foreach (string s in Country)
            {
                Console.WriteLine(s);
            }

            var countryname = from name in Country where name == "Japan" select name;
            foreach (string s in countryname)
            {
                Console.WriteLine(s);
            }
            var position = Country.FindIndex(e => e.Equals(Country.ElementAt(2)));
            var thirdcountry = Country.ElementAt(position);
            Console.WriteLine($"3rd country: {thirdcountry}");
        }
    }
}
