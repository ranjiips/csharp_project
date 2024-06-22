using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors
{
    public abstract class Armor:Equipment
    {
        private int armorPoints;
        public int ArmorPoints
        {
            get { return this.armorPoints; }
            set
            {
                if (value >= 0 && value <= 10)
                    this.armorPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the Armor value should be >=0 and <=10"); ;
            }
        }
    }
}
