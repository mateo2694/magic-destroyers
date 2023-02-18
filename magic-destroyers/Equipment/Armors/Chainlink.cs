namespace MagicDestroyers.Equipment.Armors
{
    public class Chainlink : Armor
    {
        public Chainlink() : this(Defaults.Chainlink.ARMOR_POINTS)
        {
        }

        public Chainlink(int armorPoints)
        {
            base.ArmorPoints = armorPoints;
        }
    }
}
