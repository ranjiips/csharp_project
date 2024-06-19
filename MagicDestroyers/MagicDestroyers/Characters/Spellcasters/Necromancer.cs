using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer:Spellcasters
    {
        private const string DEFAULT_NAME = "Necromancer1";
        private const int DEFAULT_LEVEL = 9;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_MANA_POINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON  = new Sword();

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
        public Necromancer():this(DEFAULT_NAME,DEFAULT_LEVEL) { }

        public Necromancer(string name, int level):this(name, level, DEFAULT_HEALTH_POINTS) { }

        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANA_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}
