using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Melee
{
    public abstract class Melee : Character
    {
        private const int MIN_ABILITY_POINTS = 0;
        private const int MAX_ABILITY_POINTS = 50;

        private int abilityPoints = MIN_ABILITY_POINTS;

        public int AbilityPoints
        {
            get => this.abilityPoints;
            protected set
            {
                if (value >= MIN_ABILITY_POINTS && value <= MAX_ABILITY_POINTS)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    var paramName = nameof(this.AbilityPoints);
                    var message = $"Error: value must be >= {MIN_ABILITY_POINTS} and <= {MAX_ABILITY_POINTS}";
                    throw new ArgumentOutOfRangeException(paramName, value, message);
                }
            }
        }

        public Melee()
        {
            base.Faction = Faction.Melee;
        }

        public abstract override void Attack();

        public abstract override void SpecialAttack();

        public abstract override void Defend();
    }
}
