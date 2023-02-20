using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Melee
    {
        private readonly LightLeatherVest BODY_ARMOR = new LightLeatherVest();

        private readonly Sword WEAPON = new Sword();

        public Assassin()
        {
            base.Name = Defaults.Assassin.NAME;
            base.AbilityPoints = Defaults.Assassin.ABILITY_POINTS;
            base.BodyArmor = BODY_ARMOR;
            base.Weapon = WEAPON;
        }

        public Assassin(string name, int level) : this()
        {
            base.Name = name;
            base.Level = level;
        }

        public Assassin(string name, int level, int healthPoints) : this(name, level)
        {
            base.HealthPoints = healthPoints;
        }

        private (string, int) Raze()
        {
            var damage = Defaults.Assassin.RAZE_POINTS + base.Weapon.Damage + base.AbilityPoints * base.Level;

            return (nameof(this.Raze), damage);
        }

        private (string, int) BleedToDeath()
        {
            var damage = Defaults.Assassin.BLEED_TO_DEATH_POINTS + base.Weapon.Damage + base.AbilityPoints * base.Level;

            return (nameof(this.BleedToDeath), damage);
        }

        private (string, int) Survival()
        {
            var armorPoints = Defaults.Assassin.SURVIVAL_POINTS + base.BodyArmor.ArmorPoints + base.AbilityPoints * base.Level;

            return (nameof(this.Survival), armorPoints);
        }

        public override (string, int) Attack()
        {
            return this.Raze();
        }

        public override (string, int) SpecialAttack()
        {
            return this.BleedToDeath();
        }

        public override (string, int) Defend()
        {
            return this.Survival();
        }
    }
}
