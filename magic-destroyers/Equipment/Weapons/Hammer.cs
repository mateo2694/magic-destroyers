namespace MagicDestroyers.Equipment.Weapons
{
    public class Hammer : Weapon
    {
        private const int DEFAULT_DAMAGE = 20;

        public Hammer() : this(DEFAULT_DAMAGE)
        {
        }

        public Hammer(int damage)
        {
            base.Damage = damage;
        }

        public void Stun()
        {
            Console.WriteLine("Stun");
        }
    }
}
