using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer
    {
        private readonly int? abilityPoints;
        private readonly int? healthPoints;
        private readonly int? level;

        private readonly string? faction;
        private readonly string? name;

        private readonly LightLeatherVest? bodyArmor;

        private readonly Sword? weapon;

        public Necromancer()
        {
        }

        public void ShadowRage()
        {
            Console.WriteLine("ShadowRage");
        }

        public void VampireTouch()
        {
            Console.WriteLine("VampireTouch");
        }

        public void BoneShield()
        {
            Console.WriteLine("BoneShield");
        }
    }
}
