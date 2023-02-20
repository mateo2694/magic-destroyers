using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private readonly LightLeatherVest BODY_ARMOR = new LightLeatherVest();

        private readonly Sword WEAPON = new Sword();

        public Necromancer()
        {
            base.Name = Defaults.Necromancer.NAME;
            base.ManaPoints = Defaults.Necromancer.MANA_POINTS;
            base.BodyArmor = BODY_ARMOR;
            base.Weapon = WEAPON;
        }

        public Necromancer(string name, int level) : this()
        {
            base.Name = name;
            base.Level = level;
        }

        public Necromancer(string name, int level, int healthPoints) : this(name, level)
        {
            base.HealthPoints = healthPoints;
        }

        private (string, int) ShadowRage()
        {
            var damage = Defaults.Necromancer.SHADOW_RAGE_POINTS + base.Weapon.Damage + base.ManaPoints * base.Level;

            return (nameof(this.ShadowRage), damage);
        }

        private (string, int) VampireTouch()
        {
            var damage = Defaults.Necromancer.VAMPIRE_TOUCH_POINTS + base.Weapon.Damage + base.ManaPoints * base.Level;

            return (nameof(this.VampireTouch), damage);
        }

        private (string, int) BoneShield()
        {
            var armorPoints = Defaults.Necromancer.BONE_SHIELD_POINTS + base.BodyArmor.ArmorPoints + base.ManaPoints * base.Level;

            return (nameof(this.BoneShield), armorPoints);
        }

        public override (string, int) Attack()
        {
            return this.ShadowRage();
        }

        public override (string, int) SpecialAttack()
        {
            return this.VampireTouch();
        }

        public override (string, int) Defend()
        {
            return this.BoneShield();
        }
    }
}
