using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        private const int MIN_ABILITY_POINTS = 0;
        private const int MAX_ABILITY_POINTS = 10;
        private const int MIN_HEALTH_POINTS = 0;
        private const int MAX_HEALTH_POINTS = 100;
        private const int MIN_LEVEL = 0;
        private const int MAX_LEVEL = 50;

        private const string DEFAULT_NAME = "Warrior";
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_ABILITY_POINTS = 10;

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Faction faction;
        private string name;

        private Chainlink bodyArmor;

        private Axe weapon;

        public int AbilityPoints
        {
            get => abilityPoints;
            private set
            {
                if (value >= MIN_ABILITY_POINTS && value <= MAX_ABILITY_POINTS)
                {
                    abilityPoints = value;
                }
                else
                {
                    var message = $"Error: {nameof(AbilityPoints)} must be >= {MIN_ABILITY_POINTS} and <= {MAX_ABILITY_POINTS}";
                    throw new ArgumentOutOfRangeException(message);
                }
            }
        }

        public int HealthPoints
        {
            get => healthPoints;
            private set
            {
                if (value >= MIN_HEALTH_POINTS && value <= MAX_HEALTH_POINTS)
                {
                    healthPoints = value;
                }
                else
                {
                    var message = $"Error: {nameof(HealthPoints)} must be >= {MIN_HEALTH_POINTS} and <= {MAX_HEALTH_POINTS}";
                    throw new ArgumentOutOfRangeException(message);
                }
            }
        }

        public int Level
        {
            get => level;
            private set
            {
                if (value >= MIN_LEVEL && value <= MAX_LEVEL)
                {
                    level = value;
                }
                else
                {
                    var message = $"Error: {nameof(Level)} must be >= {MIN_LEVEL} and <= {MAX_LEVEL}";
                    throw new ArgumentOutOfRangeException(message);
                }
            }
        }

        public Faction Faction
        {
            get => faction;
            private set => faction = value;
        }

        public Warrior() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level) : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            this.name = name;
            Level = level;
            HealthPoints = healthPoints;

            AbilityPoints = DEFAULT_ABILITY_POINTS;
            Faction = DEFAULT_FACTION;

            bodyArmor = DEFAULT_BODY_ARMOR;
            weapon = DEFAULT_WEAPON;
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
