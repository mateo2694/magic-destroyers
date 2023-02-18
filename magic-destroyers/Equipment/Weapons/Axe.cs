namespace MagicDestroyers.Equipment.Weapons
{
    public class Axe : Weapon
    {
        public Axe() : this(Defaults.Axe.DAMAGE)
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
