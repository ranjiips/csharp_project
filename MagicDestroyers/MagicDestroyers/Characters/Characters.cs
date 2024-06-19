using MagicDestroyers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    public class Characters
    {
        private int healthPoints;
        private int level;

        private string name;
        private Faction faction;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                    this.name = value;
                else
                    throw new ArgumentException(string.Empty, "Inappropriate length of name, name should be between 3 and 12 characters.");
            }
        }
        public int Level
        {
            get { return this.level; }
            set
            {
                if (value >= 0 && value <= 10)
                    this.level = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the Level value should be >=0 and <=10");
            }
        }
        public int HealthPoints
        {
            get { return this.healthPoints; }
            set
            {
                if (value >= 0 && value <= 10)
                    this.healthPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the Health value should be >=0 and <=10");
            }
        }
        public Faction Faction
        {
            get { return this.faction; }
            set { this.faction = value; }
        }
    }
}
