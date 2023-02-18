using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        private const int MIN_MANA_POINTS = 0;
        private const int MAX_MANA_POINTS = 80;

        private int manaPoints = MIN_MANA_POINTS;

        public int ManaPoints
        {
            get => this.manaPoints;
            protected set
            {
                if (value >= MIN_MANA_POINTS && value <= MAX_MANA_POINTS)
                {
                    this.manaPoints = value;
                }
                else
                {
                    var paramName = nameof(this.ManaPoints);
                    var message = $"Error: value must be >= {MIN_MANA_POINTS} and <= {MAX_MANA_POINTS}";
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
