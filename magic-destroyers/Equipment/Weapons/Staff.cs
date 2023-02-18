namespace MagicDestroyers.Equipment.Weapons
{
    public class Staff : Weapon
    {
        public Staff() : this(Defaults.Staff.DAMAGE)
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
