using System;
using MagicDestroyers;

namespace TestingProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            MagicDestroyers.Characters.Melee.Warrior warrior1 = new MagicDestroyers.Characters.Melee.Warrior();
            MagicDestroyers.Characters.Melee.Warrior warrior2 = new MagicDestroyers.Characters.Melee.Warrior();
            MagicDestroyers.Characters.Melee.Warrior warrior3 = new MagicDestroyers.Characters.Melee.Warrior();

            Console.WriteLine($"Object counter: {MagicDestroyers.Characters.Melee.Warrior.ObjCounter}");
        }
    }
}