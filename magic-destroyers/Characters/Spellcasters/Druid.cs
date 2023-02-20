using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private readonly LightLeatherVest BODY_ARMOR = new LightLeatherVest();

        private readonly Staff WEAPON = new Staff();

        public Druid()
        {
            base.Name = Defaults.Druid.NAME;
            base.ManaPoints = Defaults.Druid.MANA_POINTS;
            base.BodyArmor = BODY_ARMOR;
            base.Weapon = WEAPON;
        }

        public Druid(string name, int level) : this()
        {
            base.Name = name;
            base.Level = level;
        }

        public Druid(string name, int level, int healthPoints) : this(name, level)
        {
            base.HealthPoints = healthPoints;
        }

        private (string, int) Moonfire()
        {
            var damage = Defaults.Druid.MOONFIRE_POINTS + base.Weapon.Damage + base.ManaPoints * base.Level;

            return (nameof(this.Moonfire), damage);
        }

        private (string, int) Starburst()
        {
            var damage = Defaults.Druid.STARBURST_POINTS + base.Weapon.Damage + base.ManaPoints * base.Level;

            return (nameof(this.Starburst), damage);
        }

        private (string, int) OneWithTheNature()
        {
            var armorPoints = Defaults.Druid.ONE_WITH_THE_NATURE_POINTS + base.BodyArmor.ArmorPoints + base.ManaPoints * base.Level;

            return (nameof(this.OneWithTheNature), armorPoints);
        }

        public override (string, int) Attack()
        {
            return this.Moonfire();
        }

        public override (string, int) SpecialAttack()
        {
            return this.Starburst();
        }

        public override (string, int) Defend()
        {
            return this.OneWithTheNature();
        }
    }
}
