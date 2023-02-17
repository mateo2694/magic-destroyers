namespace MagicDestroyers.Equipment.Armors
{
    public class Armor
    {
        private const int MIN_ARMOR_POINTS = 0;
        private const int MAX_ARMOR_POINTS = 20;

        private int armorPoints = MIN_ARMOR_POINTS;

        public int ArmorPoints
        {
            get => this.armorPoints;
            protected set
            {
                if (value >= MIN_ARMOR_POINTS && value <= MAX_ARMOR_POINTS)
                {
                    this.armorPoints = value;
                }
                else
                {
                    var paramName = nameof(this.ArmorPoints);
                    var message = $"Error: value must be >= {MIN_ARMOR_POINTS} and <= {MAX_ARMOR_POINTS}";
                    throw new ArgumentOutOfRangeException(paramName, value, message);
                }
            }
        }

        public Armor()
        {
        }
    }
}
