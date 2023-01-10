using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
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
