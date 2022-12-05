using magic_destroyers.Equipment.Armors;
using magic_destroyers.Equipment.Weapons;

namespace magic_destroyers.Characters.Melee
{
    public class Warrior
    {
        private readonly int? abilityPoints;
        private readonly int? healthPoints;
        private readonly int? level;

        private readonly string? faction;
        private readonly string? name;

        private readonly Chainlink? bodyArmor;

        private readonly Axe? weapon;

        public Warrior()
        {
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
