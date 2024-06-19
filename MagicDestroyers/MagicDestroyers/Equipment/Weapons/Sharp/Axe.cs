using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe:Weapons
    {
        private const int DEFAULT_DAMAGE = 10;
        public Axe() : this(DEFAULT_DAMAGE)
        {

        }
        public Axe(int damagePoints)
        {
            this.Damage = damagePoints;
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
