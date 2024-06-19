using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior:Melee
    {
        private const string DEFAULT_NAME = "Warrior1";
        private const int DEFAULT_LEVEL = 6;
        private const int DEFAULT_HEALTHPOINTS = 70;
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        private static int objCounter;

        private Chainlink bodyArmor;
        private Axe weapon;

        public static int ObjCounter
        {
            get { return objCounter; }
            private set { objCounter = value; }
        }               

        public Chainlink BodyArmor
        {
            get { return this.bodyArmor; }
            set { this.bodyArmor = value; }
        }

        public Axe Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        public Warrior() : this(DEFAULT_NAME, DEFAULT_LEVEL) { }

        public Warrior(string name, int level) : this(name, level, DEFAULT_HEALTHPOINTS) { }

        public Warrior(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            Warrior.ObjCounter++;
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}
