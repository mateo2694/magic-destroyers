﻿using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private readonly ClothRobe BODY_ARMOR = new ClothRobe();

        private readonly Staff WEAPON = new Staff();

        public Mage()
        {
            base.Name = Defaults.Mage.NAME;
            base.ManaPoints = Defaults.Mage.MANA_POINTS;
            base.BodyArmor = BODY_ARMOR;
            base.Weapon = WEAPON;
        }

        public Mage(string name, int level) : this()
        {
            base.Name = name;
            base.Level = level;
        }

        public Mage(string name, int level, int healthPoints) : this(name, level)
        {
            base.HealthPoints = healthPoints;
        }

        private (string, int) ArcaneWrath()
        {
            var damage = Defaults.Mage.ARCANE_WRATH_POINTS + base.Weapon.Damage + base.ManaPoints * base.Level;

            return (nameof(this.ArcaneWrath), damage);
        }

        private (string, int) Firewall()
        {
            var damage = Defaults.Mage.FIREWALL_POINTS + base.Weapon.Damage + base.ManaPoints * base.Level;

            return (nameof(this.Firewall), damage);
        }

        private (string, int) Meditation()
        {
            var armorPoints = Defaults.Mage.MEDITATION_POINTS + base.BodyArmor.ArmorPoints + base.ManaPoints * base.Level;

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
