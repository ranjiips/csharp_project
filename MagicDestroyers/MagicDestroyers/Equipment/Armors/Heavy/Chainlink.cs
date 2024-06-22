using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink:Armor
    {
        private const int DEFAULT_ARMOR_POINTS = 10;
        public Chainlink():this(DEFAULT_ARMOR_POINTS)
        {
            
        }
        public Chainlink(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
