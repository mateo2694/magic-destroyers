using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        private const int MIN_HEALTH_POINTS = 0;
        private const int MAX_HEALTH_POINTS = 150;

        private const string DEFAULT_NAME = "Warrior";

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 150;
        private const int DEFAULT_ABILITY_POINTS = 10;

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();

        private readonly Axe DEFAULT_WEAPON = new Axe();

        public override int HealthPoints
        {
            get => base.healthPoints;
            protected set
            {
                if (value >= MIN_HEALTH_POINTS && value <= MAX_HEALTH_POINTS)
                {
                    base.healthPoints = value;
                }
                else
                {
                    var paramName = nameof(this.HealthPoints);
                    var message = $"Error: value must be >= {MIN_HEALTH_POINTS} and <= {MAX_HEALTH_POINTS}";
                    throw new ArgumentOutOfRangeException(paramName, value, message);
                }
            }
        }

        public Warrior() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level) : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            this.HealthPoints = healthPoints;
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
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
