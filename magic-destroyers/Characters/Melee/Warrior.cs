using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        private readonly Chainlink BODY_ARMOR = new Chainlink();

        private readonly Axe WEAPON = new Axe();

        public Warrior()
        {
            base.Name = Defaults.Warrior.NAME;
            base.AbilityPoints = Defaults.Warrior.ABILITY_POINTS;
            base.BodyArmor = BODY_ARMOR;
            base.Weapon = WEAPON;
        }

        public Warrior(string name, int level) : this()
        {
            base.Name = name;
            base.Level = level;
        }

        public Warrior(string name, int level, int healthPoints) : this(name, level)
        {
            base.HealthPoints = healthPoints;
        }

        private (string, int) Strike()
        {
            var damage = Defaults.Warrior.STRIKE_POINTS + base.Weapon.Damage + base.AbilityPoints * base.Level;

            return (nameof(this.Strike), damage);
        }

        private (string, int) Execute()
        {
            var damage = Defaults.Warrior.EXECUTE_POINTS + base.Weapon.Damage + base.AbilityPoints * base.Level;

            return (nameof(this.Execute), damage);
        }

        private (string, int) SkinHarden()
        {
            var armorPoints = Defaults.Warrior.SKIN_HARDEN_POINTS + base.BodyArmor.ArmorPoints + base.AbilityPoints * base.Level;

            return (nameof(this.SkinHarden), armorPoints);
        }

        public override (string, int) Attack()
        {
            return this.Strike();
        }

        public override (string, int) SpecialAttack()
        {
            return this.Execute();
        }

        public override (string, int) Defend()
        {
            return this.SkinHarden();
        }
    }
}
