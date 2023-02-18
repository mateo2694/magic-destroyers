namespace MagicDestroyers.Equipment.Armors
{
    public class ClothRobe : Armor
    {
        public ClothRobe() : this(Defaults.ClothRobe.ARMOR_POINTS)
        {
        }

        public ClothRobe(int armorPoints)
        {
            base.ArmorPoints = armorPoints;
        }
    }
}
