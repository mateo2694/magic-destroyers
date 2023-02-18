using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Interfaces;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttacking, IDefending
    {
        private bool isAlive = true;

        private string name = "";

        private int level = 1;
        private int healthPoints = Defaults.Character.MAX_HEALTH_POINTS;

        public bool IsAlive
        {
            get => this.isAlive;
            protected set => this.isAlive = value;
        }

        public string Name
        {
            get => this.name;
            protected set => this.name = value;
        }

        public int Level
        {
            get => this.level;
            protected set
            {
                if (value >= 0 && value <= Defaults.Character.MAX_LEVEL)
                {
                    this.level = value;
                }
                else
                {
                    var paramName = nameof(this.Level);
                    var message = $"Error: value must be >= {0} and <= {Defaults.Character.MAX_LEVEL}";

                    throw new ArgumentOutOfRangeException(paramName, value, message);
                }
            }
        }

        public int HealthPoints
        {
            get => this.healthPoints;
            protected set
            {
                if (value >= 0 && value <= Defaults.Character.MAX_HEALTH_POINTS)
                {
                    this.healthPoints = value;
                }
                else
                {
                    var paramName = nameof(this.HealthPoints);
                    var message = $"Error: value must be >= {0} and <= {Defaults.Character.MAX_HEALTH_POINTS}";

                    throw new ArgumentOutOfRangeException(paramName, value, message);
                }
            }
        }

        public Faction Faction { get; protected set; }

        public Armor BodyArmor { get; protected set; }

        public Weapon Weapon { get; protected set; }

        public Character()
        {
            this.BodyArmor = new Armor();
            this.Weapon = new Weapon();
        }

        public abstract (string, int) Attack();

        public abstract (string, int) SpecialAttack();

        public abstract (string, int) Defend();

        public void TakeDamage((string name, int damage) attack, string attackerName)
        {
            if (!this.isAlive)
            {
                Console.WriteLine($"{this.name} is already dead.");
                return;
            }

            var (defenseName, armorPoints) = this.Defend();

            if (attack.damage > armorPoints)
            {
                this.healthPoints -= attack.damage;

                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                    this.healthPoints = 0;
                }
            }
            else
            {
                Console.WriteLine($"{this.name} used {defenseName}. {attackerName}'s {attack.name} missed.");
            }

            Console.WriteLine($"{attackerName}'s {attack.name} was effective.");
            Console.WriteLine($"{this.name}'s {nameof(this.HealthPoints)}: {this.healthPoints}");

            if (!this.isAlive)
            {
                Console.WriteLine($"{this.name} is dead.");
            }
        }
    }
}
