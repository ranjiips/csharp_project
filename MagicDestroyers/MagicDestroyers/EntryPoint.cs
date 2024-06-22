using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;

namespace MagicDestroyers
{
    class EntryPoint
    {
        public static void Main()
        {
            Random rng = new Random();

            Melee currentMelee;
            Spellcasters currentSpellcaster;

            bool gameOver = false;
            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Knight(),
                new Assassin(),
                new Mage(),
                new Druid(),
                new Necromancer(),
                //new Warrior("Warrior_Gobi",1),
                //new Warrior("Warrior_Hari",1),
                //new Mage("Mage_Thamizh",1,200),
                //new Mage("Mage_Kannan",1,200)
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcasters> spellTeam = new List<Spellcasters>();

            foreach (var character in characters)
            {
                if (character is Melee)
                    meleeTeam.Add((Melee)character);
                else if (character is Spellcasters)
                    spellTeam.Add((Spellcasters)character);
            }

            while (!gameOver)
            {
                // 1. Take a random Melee character
                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                // 2. Take a random Spellcaster character
                currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];

                // 3. Melee attacks Spellcaster
                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());
                // 3.1 Check if the character died and remove him from the team
                // 3.2 If dead, get another character from the team
                if (!currentSpellcaster.IsAlive)
                {
                    currentMelee.WonBattle();
                    spellTeam.Remove(currentSpellcaster);
                    if (spellTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team Wins!!");
                        break;
                    }
                    else
                        currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];
                }

                // 4. Spellcaster attacks Melee
                currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name, currentMelee.GetType().ToString());

                // 4.1 Check if the character died and remove him from the team
                // 4.2 If dead, get another character from the team
                if (!currentMelee.IsAlive)
                {
                    currentSpellcaster.WonBattle();
                    meleeTeam.Remove(currentMelee);
                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spell team Wins!!");
                        
                        break;
                    }
                    else
                        currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                }

                // 5 If no characters are alive from either of the teams, then gameover = true                
            }

            //PlayersInfo.UpdateFullInfo(characters);
            //PlayersInfo.Save(characters);
            //PlayersInfo.PrintFullInfo();
        }
    }

}