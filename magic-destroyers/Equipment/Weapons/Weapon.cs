namespace MagicDestroyers.Equipment.Weapons
{
    public class Weapon
    {
        private int damage;

        public int Damage
        {
            get => this.damage;
            protected set
            {
                if (value >= 0 && value <= Defaults.Weapon.MAX_DAMAGE)
                {
                    this.damage = value;
                }
                else
                {
                    var paramName = nameof(this.Damage);
                    var message = $"Error: value must be >= {0} and <= {Defaults.Weapon.MAX_DAMAGE}";

                    throw new ArgumentOutOfRangeException(paramName, value, message);
                }
            }
        }

        public Weapon()
        {
        }
    }
}
