namespace MagicDestroyers.Equipment.Armors
{
    public class ClothRobe : Armor
    {
        private const int DEFAULT_ARMOR_POINTS = 5;

        public ClothRobe() : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public ClothRobe(int armorPoints)
        {
            base.ArmorPoints = armorPoints;
        }
    }
}
