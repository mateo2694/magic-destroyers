using magic_destroyers.Equipment.Armors;
using magic_destroyers.Equipment.Weapons;

namespace magic_destroyers.Characters.Spellcasters
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
