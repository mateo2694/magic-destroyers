using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Melee
{
    public class Melee : Character
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
                    var message = $"Error: {nameof(this.AbilityPoints)} must be >= {MIN_ABILITY_POINTS} and <= {MAX_ABILITY_POINTS}";
                    throw new ArgumentOutOfRangeException(message);
                }
            }
        }

        public Melee()
        {
            base.Faction = Faction.Melee;
        }
    }
}
