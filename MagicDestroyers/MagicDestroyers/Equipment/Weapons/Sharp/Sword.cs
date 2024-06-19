using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword:Weapons
    {
        private const int DEFAULT_DAMAGE = 10;
        public Sword() : this(DEFAULT_DAMAGE)
        {

        }
        public Sword(int damagePoints)
        {
            this.Damage = damagePoints;
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
