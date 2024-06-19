using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer:Weapons
    {
        private const int DEFAULT_DAMAGE = 10;
        public Hammer():this(DEFAULT_DAMAGE)
        {
            
        }
        public Hammer(int damagePoints)
        {
            this.Damage=damagePoints;
        }
        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
