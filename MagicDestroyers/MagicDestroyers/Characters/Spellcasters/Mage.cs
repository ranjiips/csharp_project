using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage:Spellcasters
    {
        private const string DEFAULT_NAME = "Warrior1";
        private const int DEFAULT_LEVEL = 6;
        private const int DEFAULT_HEALTHPOINTS = 70;
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const int DEFAULT_MANA_POINTS = 100;
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private ClothRobe bodyArmor;
        private Staff weapon;

        public ClothRobe BodyArmor
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
        public Staff Weapon
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
        public Mage():this(DEFAULT_NAME,DEFAULT_LEVEL) { }

        public Mage(string name, int level):this(name, level, DEFAULT_HEALTHPOINTS) { }

        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANA_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Firewall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}
