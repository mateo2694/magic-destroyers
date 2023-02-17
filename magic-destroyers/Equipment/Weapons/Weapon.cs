namespace MagicDestroyers.Equipment.Weapons
{
    public class Weapon
    {
        private const int MIN_DAMAGE = 0;
        private const int MAX_DAMAGE = 30;

        private int damage = MIN_DAMAGE;

        public int Damage
        {
            get => this.damage;
            protected set
            {
                if (value >= MIN_DAMAGE && value <= MAX_DAMAGE)
                {
                    this.damage = value;
                }
                else
                {
                    var paramName = nameof(this.Damage);
                    var message = $"Error: value must be >= {MIN_DAMAGE} and <= {MAX_DAMAGE}";
                    throw new ArgumentOutOfRangeException(paramName, value, message);
                }
            }
        }

        public Weapon()
        {
        }
    }
}
