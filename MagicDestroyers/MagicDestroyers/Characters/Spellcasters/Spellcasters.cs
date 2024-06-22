using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public abstract class Spellcasters: Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get { return this.manaPoints; }
            set
            {
                if (value >= 0)
                    this.manaPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the Mana value should be >=0");
            }
        }
    }
}
