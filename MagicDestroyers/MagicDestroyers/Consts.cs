using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers
{
    public static class Consts
    {
        public static class Warrior
        {
            public const string NAME = "Warrior_Bob";
            public const int LEVEL = 1;
            public const int HEALTHPOINTS = 120;
            public const Faction FACTION = Faction.Melee;
            public const int ABILITY_POINTS = 100;
        }

        public static class Mage
        {
            public const string NAME = "Mage_Merlin";
            public const int LEVEL = 1;
            public const int HEALTHPOINTS = 120;
            public const Faction FACTION = Faction.Spellcaster;
            public const int MANA_POINTS = 100;
        }

        public static class Druid
        {
            public const string NAME = "Druid_Cenarius";
            public const int LEVEL = 1;
            public const int HEALTHPOINTS = 120;
            public const Faction FACTION = Faction.Spellcaster;
            public const int MANA_POINTS = 100;
        }

        public static class Knight
        {
            public const string NAME = "Knight_Uther";
            public const int LEVEL = 1;
            public const int HEALTHPOINTS = 120;
            public const Faction FACTION = Faction.Melee;
            public const int ABILITY_POINTS = 100;
        }

        public static class Assassin
        {
            public const string NAME = "Warrior1";
            public const int LEVEL = 1;
            public const int HEALTHPOINTS = 70;
            public const Faction FACTION = Faction.Melee;
            public const int ABILITY_POINTS = 100;
        }

        public static class Neromancer
        {
            public const string NAME = "Necromancer1";
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 100;
            public const int MANA_POINTS = 100;
            public const Faction FACTION = Faction.Spellcaster;
        }
    }
}
