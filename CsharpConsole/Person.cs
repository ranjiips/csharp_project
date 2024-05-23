using System;
using System.Collections.Generic;

namespace CsharpConsole
{
    public partial class Person
    {
        public string Name;
        public int Age;

        public Person()
        {

        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public void IntroduceAge(string to)
        {
            Console.WriteLine("Hi {0}, I am {1} years old", to, Age);
        }

        public static Person Parse(int age)
        {
            var person = new Person();
            person.Age = age;
            return person;
        }
    }
}