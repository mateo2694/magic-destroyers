using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private Chainlink bodyArmor;

        private Axe weapon;

        public int AbilityPoints
        {
            get => abilityPoints;
            private set
            {
                if (value >= 0 && value <= 10)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Error: {nameof(AbilityPoints)} must be >= 0 and <= 10");
                }
            }
        }

        public int HealthPoints
        {
            get => healthPoints;
            private set
            {
                if (value >= 0 && value <= 100)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Error: {nameof(HealthPoints)} must be >= 0 and <= 100");
                }
            }
        }

        public int Level
        {
            get => level;
            private set
            {
                if (value >= 0 && value <= 50)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Error: {nameof(Level)} must be >= 0 and <= 50");
                }
            }
        }

        public string Faction
        {
            get => faction;
            private set
            {
                if (value == "Melee" || value == "SpellCasters")
                {
                    faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Error: {nameof(Faction)} must be \"Melee\" or \"SpellCasters\"");
                }
            }
        }

        public Warrior() : this("Warrior", 1)
        {
        }

        public Warrior(string name, int level) : this(name, level, 100)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            AbilityPoints = 10;
            HealthPoints = healthPoints;
            Level = level;
            Faction = "Melee";

            this.name = name;

            bodyArmor = new Chainlink();
            weapon = new Axe();
        }

        public void Strike()
        {
            Console.WriteLine("Strike");
        }

        public void Execute()
        {
            Console.WriteLine("Execute");
        }

        public void SkinHarden()
        {
            Console.WriteLine("SkinHarden");
        }
    }
}
