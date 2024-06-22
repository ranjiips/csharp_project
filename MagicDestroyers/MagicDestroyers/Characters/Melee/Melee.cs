using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public abstract class Melee: Character
    {
        private int abilityPoints;

        public int AbilityPoints
        {
            get { return this.abilityPoints; }
            set
            {
                if (value >= 0)
                    this.abilityPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the Ability value should be >=0");
            }
        }
    }
}
