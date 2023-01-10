using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight
    {
        private readonly int? abilityPoints;
        private readonly int? healthPoints;
        private readonly int? level;

        private readonly string? faction;
        private readonly string? name;

        private readonly Chainlink? bodyArmor;

        private readonly Hammer? weapon;

        public Knight()
        {
        }

        public void HolyBlow()
        {
            Console.WriteLine("HolyBlow");
        }

        public void PurifySoul()
        {
            Console.WriteLine("PurifySoul");
        }

        public void RighteousWings()
        {
            Console.WriteLine("RighteousWings");
        }
    }
}
