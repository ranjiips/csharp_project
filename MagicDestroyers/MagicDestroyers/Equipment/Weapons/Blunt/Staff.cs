using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff:Weapons
    {
        private const int DEFAULT_DAMAGE = 10;
        public Staff() : this(DEFAULT_DAMAGE)
        {

        }
        public Staff(int damagePoints)
        {
            this.Damage = damagePoints;
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
