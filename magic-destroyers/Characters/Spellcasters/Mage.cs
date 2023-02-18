using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private const string DEFAULT_NAME = "Mage";

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_MANA_POINTS = 20;

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();

        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Mage() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Mage(string name, int level) : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            this.HealthPoints = healthPoints;
            base.ManaPoints = DEFAULT_MANA_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        private (string, int) ArcaneWrath()
        {
            var damage = base.Weapon?.Damage ?? 0;

            return (nameof(this.ArcaneWrath), damage);
        }

        private (string, int) Firewall()
        {
            var damage = base.Weapon?.Damage ?? 0;

            return (nameof(this.Firewall), damage);
        }

        private (string, int) Meditation()
        {
            var armorPoints = base.BodyArmor?.ArmorPoints ?? 0;

            return (nameof(this.Meditation), armorPoints);
        }

        public override (string, int) Attack()
        {
            return this.ArcaneWrath();
        }

        public override (string, int) SpecialAttack()
        {
            return this.Firewall();
        }

        public override (string, int) Defend()
        {
            return this.Meditation();
        }
    }
}
