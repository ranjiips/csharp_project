using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight:Melee
    {
        private const string DEFAULT_NAME = "Warrior1";
        private const int DEFAULT_LEVEL = 6;
        private const int DEFAULT_HEALTHPOINTS = 70;
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        private Chainlink bodyArmor;
        private Hammer weapon;        

        public Chainlink BodyArmor
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
        public Hammer Weapon
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

        public Knight():this(DEFAULT_NAME,DEFAULT_LEVEL) { }

        public Knight(string name, int level):this(name, level, DEFAULT_HEALTHPOINTS){ }

        public Knight(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction =  DEFAULT_FACTION;
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}
