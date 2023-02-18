namespace MagicDestroyers.Equipment.Weapons
{
    public class Sword : Weapon
    {
        public Sword() : this(Defaults.Sword.DAMAGE)
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
