﻿using MagicDestroyers.Enums;
using MagicDestroyers.Interfaces;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttacking, IDefending
    {
        private const int MIN_LEVEL = 0;
        private const int MAX_LEVEL = 100;
        private const int MIN_HEALTH_POINTS = 0;
        private const int MAX_HEALTH_POINTS = 100;

        private Faction faction;

        private string name = "";

        private int level = MIN_LEVEL;

        protected int healthPoints = MIN_HEALTH_POINTS;

        public Faction Faction
        {
            get => this.faction;
            protected set => this.faction = value;
        }

        public string Name
        {
            get => this.name;
            protected set => this.name = value;
        }

        public int Level
        {
            get => this.level;
            protected set
            {
                if (value >= MIN_LEVEL && value <= MAX_LEVEL)
                {
                    this.level = value;
                }
                else
                {
                    var paramName = nameof(this.Level);
                    var message = $"Error: value must be >= {MIN_LEVEL} and <= {MAX_LEVEL}";
                    throw new ArgumentOutOfRangeException(paramName, value, message);
                }
            }
        }

        public virtual int HealthPoints
        {
            get => this.healthPoints;
            protected set
            {
                if (value >= MIN_HEALTH_POINTS && value <= MAX_HEALTH_POINTS)
                {
                    this.healthPoints = value;
                }
                else
                {
                    var paramName = nameof(this.HealthPoints);
                    var message = $"Error: value must be >= {MIN_HEALTH_POINTS} and <= {MAX_HEALTH_POINTS}";
                    throw new ArgumentOutOfRangeException(paramName, value, message);
                }
            }
        }

        public Character()
        {
        }

        public abstract void Attack();

        public abstract void SpecialAttack();

        public abstract void Defend();
    }
}
