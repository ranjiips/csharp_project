﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Leather
{
    public class LightLeatherVest:Armor
    {
        private const int DEFAULT_ARMOR_POINTS = 10;

        public LightLeatherVest() : this(DEFAULT_ARMOR_POINTS)
        {

        }
        public LightLeatherVest(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
