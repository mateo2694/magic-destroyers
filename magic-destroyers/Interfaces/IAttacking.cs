namespace MagicDestroyers.Interfaces
{
    public interface IAttacking
    {
        (string, int) Attack();
        (string, int) SpecialAttack();
    }
}
