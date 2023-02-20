using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {
        private readonly Chainlink BODY_ARMOR = new Chainlink();

        private readonly Hammer WEAPON = new Hammer();

        public Knight()
        {
            base.Name = Defaults.Knight.NAME;
            base.AbilityPoints = Defaults.Knight.ABILITY_POINTS;
            base.BodyArmor = BODY_ARMOR;
            base.Weapon = WEAPON;
        }

        public Knight(string name, int level) : this()
        {
            base.Name = name;
            base.Level = level;
        }

        public Knight(string name, int level, int healthPoints) : this(name, level)
        {
            base.HealthPoints = healthPoints;
        }

        private (string, int) HolyBlow()
        {
            var damage = Defaults.Knight.HOLY_BLOW_POINTS + base.Weapon.Damage + base.AbilityPoints * base.Level;

            return (nameof(this.HolyBlow), damage);
        }

        private (string, int) PurifySoul()
        {
            var damage = Defaults.Knight.PURIFY_SOUL_POINTS + base.Weapon.Damage + base.AbilityPoints * base.Level;

            return (nameof(this.PurifySoul), damage);
        }

        private (string, int) RighteousWings()
        {
            var armorPoints = Defaults.Knight.RIGHTEOUS_WINGS_POINTS + base.BodyArmor.ArmorPoints + base.AbilityPoints * base.Level;

            return (nameof(this.RighteousWings), armorPoints);
        }

        public override (string, int) Attack()
        {
            return this.HolyBlow();
        }

        public override (string, int) SpecialAttack()
        {
            return this.PurifySoul();
        }

        public override (string, int) Defend()
        {
            return this.RighteousWings();
        }
    }
}
