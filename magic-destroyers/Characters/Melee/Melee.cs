using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Melee
{
    public abstract class Melee : Character
    {
        private int abilityPoints;

        public int AbilityPoints
        {
            get => this.abilityPoints;
            protected set
            {
                if (value >= 0 && value <= Defaults.Melee.MAX_ABILITY_POINTS)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    var paramName = nameof(this.AbilityPoints);
                    var message = $"Error: value must be >= {0} and <= {Defaults.Melee.MAX_ABILITY_POINTS}";

                    throw new ArgumentOutOfRangeException(paramName, value, message);
                }
            }
        }

        public Melee()
        {
            base.Faction = Faction.Melee;
        }

        public abstract override (string, int) Attack();

        public abstract override (string, int) SpecialAttack();

        public abstract override (string, int) Defend();
    }
}
