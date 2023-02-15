using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Spellcaster : Character
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
                    var message = $"Error: {nameof(this.ManaPoints)} must be >= {MIN_MANA_POINTS} and <= {MAX_MANA_POINTS}";
                    throw new ArgumentOutOfRangeException(message);
                }
            }
        }

        public Spellcaster()
        {
            base.Faction = Faction.Spellcasters;
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
