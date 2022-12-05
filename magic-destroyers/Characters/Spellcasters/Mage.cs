using magic_destroyers.Equipment.Armors;
using magic_destroyers.Equipment.Weapons;

namespace magic_destroyers.Characters.Spellcasters
{
    public class Mage
    {
        private readonly int? abilityPoints;
        private readonly int? healthPoints;
        private readonly int? level;

        private readonly string? faction;
        private readonly string? name;

        private readonly ClothRobe? bodyArmor;

        private readonly Staff? weapon;

        public Mage()
        {
        }

        public void ArcaneWrath()
        {
            Console.WriteLine("ArcaneWrath");
        }

        public void Firewall()
        {
            Console.WriteLine("Firewall");
        }

        public void Meditation()
        {
            Console.WriteLine("Meditation");
        }
    }
}
