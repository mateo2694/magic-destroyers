namespace MagicDestroyers.Equipment.Armors
{
    public class LightLeatherVest : Armor
    {
        public LightLeatherVest() : this(Defaults.LightLeatherVest.ARMOR_POINTS)
        {
        }

        public LightLeatherVest(int armorPoints)
        {
            base.ArmorPoints = armorPoints;
        }
    }
}
