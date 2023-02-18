namespace MagicDestroyers.Equipment.Armors
{
    public class Armor
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get => this.armorPoints;
            protected set
            {
                if (value >= 0 && value <= Defaults.Armor.MAX_ARMOR_POINTS)
                {
                    this.armorPoints = value;
                }
                else
                {
                    var paramName = nameof(this.ArmorPoints);
                    var message = $"Error: value must be >= {0} and <= {Defaults.Armor.MAX_ARMOR_POINTS}";

                    throw new ArgumentOutOfRangeException(paramName, value, message);
                }
            }
        }

        public Armor()
        {
        }
    }
}
