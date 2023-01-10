using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin
    {
        private readonly int? abilityPoints;
        private readonly int? healthPoints;
        private readonly int? level;

        private readonly string? faction;
        private readonly string? name;

        private readonly LightLeatherVest? bodyArmor;

        private readonly Sword? weapon;

        public Assassin()
        {
        }

        public void Raze()
        {
            Console.WriteLine("Raze");
        }

        public void BleedToDeath()
        {
            Console.WriteLine("BleedToDeath");
        }

        public void Survival()
        {
            Console.WriteLine("Survival");
        }
    }
}
