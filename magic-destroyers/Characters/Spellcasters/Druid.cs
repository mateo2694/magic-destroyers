using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid
    {
        private readonly int? abilityPoints;
        private readonly int? healthPoints;
        private readonly int? level;

        private readonly string? faction;
        private readonly string? name;

        private readonly LightLeatherVest? bodyArmor;

        private readonly Staff? weapon;

        public Druid()
        {
        }

        public void Moonfire()
        {
            Console.WriteLine("Moonfire");
        }

        public void Starburst()
        {
            Console.WriteLine("Starburst");
        }

        public void OneWithTheNature()
        {
            Console.WriteLine("OneWithTheNature");
        }
    }
}
