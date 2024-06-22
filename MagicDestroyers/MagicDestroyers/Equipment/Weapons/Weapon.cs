using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons
{
    public abstract class Weapon:Equipment
    {
        private int damagePoints;

        public int DamagePoints
        {
            get { return this.damagePoints; }
            set
            {
                if (value >= 0 && value <= 10)
                    this.damagePoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the Damage value should be >=0 and <=10"); ;
            }
        }

        public abstract void SpecialAbility();
    }
}
