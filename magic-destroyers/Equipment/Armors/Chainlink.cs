namespace MagicDestroyers.Equipment.Armors
{
    public class Chainlink : Armor
    {
        private const int DEFAULT_ARMOR_POINTS = 20;

        public Chainlink() : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public Chainlink(int armorPoints)
        {
            base.ArmorPoints = armorPoints;
        }
    }
}
