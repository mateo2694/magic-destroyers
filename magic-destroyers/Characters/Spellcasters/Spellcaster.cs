using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get => this.manaPoints;
            protected set
            {
                if (value >= 0 && value <= Defaults.Spellcaster.MAX_MANA_POINTS)
                {
                    this.manaPoints = value;
                }
                else
                {
                    var paramName = nameof(this.ManaPoints);
                    var message = $"Error: value must be >= {0} and <= {Defaults.Spellcaster.MAX_MANA_POINTS}";

                    throw new ArgumentOutOfRangeException(paramName, value, message);
                }
            }
        }

        public Spellcaster()
        {
            base.Faction = Faction.Spellcasters;
        }

        public abstract override (string, int) Attack();

        public abstract override (string, int) SpecialAttack();

        public abstract override (string, int) Defend();
    }
}
