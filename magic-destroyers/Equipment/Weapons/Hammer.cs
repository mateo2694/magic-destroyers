namespace MagicDestroyers.Equipment.Weapons
{
    public class Hammer : Weapon
    {
        public Hammer() : this(Defaults.Hammer.DAMAGE)
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
