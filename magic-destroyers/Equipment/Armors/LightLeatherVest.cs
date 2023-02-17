﻿namespace MagicDestroyers.Equipment.Armors
{
    public class LightLeatherVest : Armor
    {
        private const int DEFAULT_ARMOR_POINTS = 10;

        public LightLeatherVest() : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public LightLeatherVest(int armorPoints)
        {
            base.ArmorPoints = armorPoints;
        }
    }
}
