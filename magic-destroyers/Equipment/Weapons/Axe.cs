namespace MagicDestroyers.Equipment.Weapons
{
    public class Axe : Weapon
    {
        private const int DEFAULT_DAMAGE = 30;

        public Axe() : this(DEFAULT_DAMAGE)
        {
        }

        public Axe(int damage)
        {
            base.Damage = damage;
        }

        public void HackNSlash()
        {
            Console.WriteLine("HackNSlash");
        }
    }
}
