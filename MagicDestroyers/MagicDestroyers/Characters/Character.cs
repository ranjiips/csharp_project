using MagicDestroyers.Characters.Interfaces;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private int healthPoints;
        private int level;

        private string name;
        private Faction faction;

        private Armor bodyArmor;
        private Weapon weapon;

        private bool isAlive;
        private int scores;

        public bool IsAlive
        {
            get { return this.isAlive; }
            set { this.isAlive = value; }
        }

        public int Scores
        {
            get { return this.scores; }
            set { this.scores = value; }
        }

        public Armor BodyArmor
        {
            get { return this.bodyArmor; }
            set { this.bodyArmor = value; }
        }

        public Weapon Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 50)
                    this.name = value;
                else
                    throw new ArgumentException(string.Empty, "Inappropriate length of name, name should be between 3 and 50 characters.");
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
                if (value >= 0)
                    this.healthPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the Health value should be >=0");
            }
        }
        public Faction Faction
        {
            get { return this.faction; }
            set { this.faction = value; }
        }

        public abstract int Attack();

        public abstract int Defend();

        public abstract int SpecialAttack();

        public void TakeDamage(int damage, string attackerName, string type)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();
                if(this.healthPoints <=0)
                    this.isAlive = false;
            }
            else
                Console.WriteLine($"Hey {attackerName}, You cannot damage me ({this.name}), your damage is not enough to Harm me");

            if(!this.IsAlive)
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and is now dead!", type);
            else
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and now has {this.healthPoints} healthpoints!", type);
        }

        public void WonBattle()
        {
            this.scores++;
            if(this.scores%10 == 0)
                this.level++;
        }
    }
}
