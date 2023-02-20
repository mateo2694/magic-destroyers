namespace MagicDestroyers
{
    public static class Defaults
    {
        public static class Character
        {
            public const int MAX_LEVEL = 10;
            public const int MAX_HEALTH_POINTS = 100;
            public const int EFFECTIVE_ATTACK_SCORE = 2;
            public const int LETHAL_ATTACK_SCORE = 5;
            public const int LEVEL_UP_SCORE = 10;
        }

        public static class Melee
        {
            public const int MAX_ABILITY_POINTS = 4;
        }

        public static class Assassin
        {
            public const string NAME = nameof(Assassin);
            public const int ABILITY_POINTS = 3;
            public const int RAZE_POINTS = 10;
            public const int BLEED_TO_DEATH_POINTS = 16;
            public const int SURVIVAL_POINTS = 6;
        }

        public static class Knight
        {
            public const string NAME = nameof(Knight);
            public const int ABILITY_POINTS = 4;
            public const int HOLY_BLOW_POINTS = 10;
            public const int PURIFY_SOUL_POINTS = 14;
            public const int RIGHTEOUS_WINGS_POINTS = 8;
        }

        public static class Warrior
        {
            public const string NAME = nameof(Warrior);
            public const int ABILITY_POINTS = 3;
            public const int STRIKE_POINTS = 8;
            public const int EXECUTE_POINTS = 12;
            public const int SKIN_HARDEN_POINTS = 10;
        }

        public static class Spellcaster
        {
            public const int MAX_MANA_POINTS = 6;
        }

        public static class Druid
        {
            public const string NAME = nameof(Druid);
            public const int MANA_POINTS = 5;
            public const int MOONFIRE_POINTS = 12;
            public const int STARBURST_POINTS = 20;
            public const int ONE_WITH_THE_NATURE_POINTS = 8;
        }

        public static class Mage
        {
            public const string NAME = nameof(Mage);
            public const int MANA_POINTS = 6;
            public const int ARCANE_WRATH_POINTS = 12;
            public const int FIREWALL_POINTS = 18;
            public const int MEDITATION_POINTS = 6;
        }

        public static class Necromancer
        {
            public const string NAME = nameof(Necromancer);
            public const int MANA_POINTS = 4;
            public const int SHADOW_RAGE_POINTS = 10;
            public const int VAMPIRE_TOUCH_POINTS = 16;
            public const int BONE_SHIELD_POINTS = 12;
        }

        public static class Armor
        {
            public const int MAX_ARMOR_POINTS = 12;
        }

        public static class Chainlink
        {
            public const int ARMOR_POINTS = 12;
        }

        public static class ClothRobe
        {
            public const int ARMOR_POINTS = 4;
        }

        public static class LightLeatherVest
        {
            public const int ARMOR_POINTS = 8;
        }

        public static class Weapon
        {
            public const int MAX_DAMAGE = 20;
        }

        public static class Axe
        {
            public const int DAMAGE = 20;
        }

        public static class Hammer
        {
            public const int DAMAGE = 12;
        }

        public static class Staff
        {
            public const int DAMAGE = 8;
        }

        public static class Sword
        {
            public const int DAMAGE = 16;
        }
    }
}
