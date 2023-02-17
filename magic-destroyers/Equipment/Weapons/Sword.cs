namespace MagicDestroyers.Equipment.Weapons
{
    public class Sword : Weapon
    {
        private const int DEFAULT_DAMAGE = 25;

        public Sword() : this(DEFAULT_DAMAGE)
        {
        }

        public Sword(int damage)
        {
            base.Damage = damage;
        }

        public void Bloodthirst()
        {
            Console.WriteLine("Bloodthirst");
        }
    }
}
