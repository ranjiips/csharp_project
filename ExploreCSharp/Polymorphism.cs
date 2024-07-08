using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class Polymorphism
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public string Add(string str1, string str2)
        {
            return str1 + str2;            
        }
    }

    class Animals
    {
        public virtual void Eating()
        {
            
            Console.WriteLine("All the animals are eating");
        }

        public virtual void MakingNoise()
        {
            Console.WriteLine("All the animals are making noise");
        }
    }

    class Dog:Animals
    {
        public override void Eating()
        {
            Console.WriteLine("Dogs are eating the meats");
        }

        public override void MakingNoise()
        {
            Console.WriteLine("Dogs are barking");
        }
    }

    class Cats : Animals
    {
        public override void Eating()
        {
            Console.WriteLine("Cats are drinking the milk");
        }

        public override void MakingNoise()
        {
            Console.WriteLine("Cats meow");
        }
    }

}
