using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin:Melee
    {
        private const string DEFAULT_NAME = "Warrior1";
        private const int DEFAULT_LEVEL = 6;
        private const int DEFAULT_HEALTHPOINTS = 70;
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public LightLeatherVest BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Sword Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }
        public Assassin():this(DEFAULT_NAME, DEFAULT_LEVEL) { }

        public Assassin(string name, int level) : this(name, level, DEFAULT_HEALTHPOINTS) { }

        public Assassin(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
