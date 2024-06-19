using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid:Spellcasters
    {
        private const string DEFAULT_NAME = "Warrior1";
        private const int DEFAULT_LEVEL = 6;
        private const int DEFAULT_HEALTHPOINTS = 70;
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const int DEFAULT_MANA_POINTS = 100;
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private LightLeatherVest bodyArmor;
        private Staff weapon;

        public LightLeatherVest BodyArmor
        {
            get { return this.bodyArmor; }
            set { this.bodyArmor = value; }
        }

        public Staff Weapon
        {
            get { return weapon; }
            set { this.weapon = value; }
        }
        public Druid():this(DEFAULT_NAME,DEFAULT_LEVEL) { }

        public Druid(string name, int level):this(name, level, DEFAULT_HEALTHPOINTS) { }

        public Druid(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints; 
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANA_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}
