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
            public const string NAME = "Assassin";
            public const int ABILITY_POINTS = 3;
        }

        public static class Knight
        {
            public const string NAME = "Knight";
            public const int ABILITY_POINTS = 4;
        }

        public static class Warrior
        {
            public const string NAME = "Warrior";
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
            public const string NAME = "Druid";
            public const int MANA_POINTS = 6;
        }

        public static class Mage
        {
            public const string NAME = "Mage";
            public const int MANA_POINTS = 6;
            public const int ARCANE_WRATH_POINTS = 12;
            public const int FIREWALL_POINTS = 20;
            public const int MEDITATION_POINTS = 6;
        }

        public static class Necromancer
        {
            public const string NAME = "Necromancer";
            public const int MANA_POINTS = 5;
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
