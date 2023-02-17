namespace MagicDestroyers.Equipment.Weapons
{
    public class Staff : Weapon
    {
        private const int DEFAULT_DAMAGE = 15;

        public Staff() : this(DEFAULT_DAMAGE)
        {
        }

        public Staff(int damage)
        {
            base.Damage = damage;
        }

        public void Empower()
        {
            Console.WriteLine("Empower");
        }
    }
}
