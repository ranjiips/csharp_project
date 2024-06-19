using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons
{
    public class Weapons:Equipment
    {
        private int damage;

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value >= 0 && value <= 10)
                    this.damage = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the Damage value should be >=0 and <=10"); ;
            }
        }
    }
}
