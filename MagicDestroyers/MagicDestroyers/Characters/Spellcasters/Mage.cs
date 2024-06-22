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
        

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        //private ClothRobe bodyArmor;
        //private Staff weapon;

        //public ClothRobe BodyArmor
        //{
        //    get
        //    {
        //        return this.bodyArmor;
        //    }
        //    set
        //    {
        //        this.bodyArmor = value;
        //    }
        //}
        //public Staff Weapon
        //{
        //    get
        //    {
        //        return this.weapon;
        //    }
        //    set
        //    {
        //        this.weapon = value;
        //    }
        //}
        public Mage():this(Consts.Mage.NAME,Consts.Mage.LEVEL) { }

        public Mage(string name, int level):this(name, level, Consts.Mage.HEALTHPOINTS) { }

        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Mage.FACTION;
            base.ManaPoints = Consts.Mage.MANA_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public int Fireball()
        {
            return base.Weapon.DamagePoints + 5;
        }

        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Fireball();
        }

        public override int Defend()
        {
            return this.Meditation();
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }
    }
}
