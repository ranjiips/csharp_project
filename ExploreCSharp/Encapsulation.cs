using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class Encapsulation
    {
        private string _name;
        private int _age;
        private string _city;
        public string Country;
        private string cityName = "Chennai";
        public DateTime Birthdate { get; set; }
        public string CityName { get; set; }

        public Encapsulation()
        {
            GetCity(cityName);
        }
            

        public string Name
        {
            get { return _name;  }
            set { _name = value;  }
        }

        public int Age
        {
            get 
            {
                var timeSpan = DateTime.Today - Birthdate;
                _age = timeSpan.Days / 365;
                return _age;
            }
            //set { _age = Age; }

        }

        private string City
        {
            get { return _city;  }
            set { _city = value; }
        }

        public void GetCity(string cityName)
        {
            City = cityName;
            //return City;
        }

        

        public void DisplayDetails()
        {
            Console.WriteLine($"My name is { Name }");
            Console.WriteLine($"I am { Age } year old");
            Console.WriteLine($"I am from the city: { City }");
            Console.WriteLine($"I am from the Country: { Country }");
        }
    }
}
