using MagicDestroyers.Characters.Melee.Melee;

namespace MagicDestroyers
{
    class EntryPoint
    {
        public static void Main()
        {
            try
            {
                Warrior warrior1 = new Warrior();
                Warrior warrior2 = new Warrior("Warrior2", 3);
                Warrior warrior3 = new Warrior("Warrior3", 6, 5);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}