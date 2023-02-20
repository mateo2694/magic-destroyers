using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;

namespace MagicDestroyers
{
    class Program
    {
        static void Main()
        {
            int round = 0;

            Random random = new Random();

            List<Character> characters = new List<Character>()
            {
                new Assassin(),
                new Knight(),
                new Warrior(),
                new Druid(),
                new Mage(),
                new Necromancer(),
            };

            List<Melee> meleeTeam = new List<Melee>();

            List<Spellcaster> spellTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }

            Console.WriteLine($"{Environment.NewLine}GAME ON!");

            while (true)
            {
                // If all members of a team died game is over
                if (meleeTeam.Count == 0)
                {
                    Console.WriteLine($"{Environment.NewLine}SPELLCASTER TEAM WINS!");
                    break;
                }
                else if (spellTeam.Count == 0)
                {
                    Console.WriteLine($"{Environment.NewLine}MELEE TEAM WINS!");
                    break;
                }

                // Take random Melee
                var meleeCharacter = meleeTeam[random.Next(meleeTeam.Count)];

                // Take random Spellcaster
                var spellCharacter = spellTeam[random.Next(spellTeam.Count)];

                Console.WriteLine($"{Environment.NewLine}ROUND {++round} -> {meleeCharacter.Name} vs {spellCharacter.Name}");
                Console.WriteLine();

                // Melee attacks Spellcaster
                Fight(meleeCharacter, spellCharacter);

                // If Spellcaster died remove it from team
                if (!spellCharacter.IsAlive)
                {
                    spellTeam.Remove(spellCharacter);
                    continue;
                }

                // Spellcaster attacks Melee
                Fight(spellCharacter, meleeCharacter);

                // If Melee died remove it from team
                if (!meleeCharacter.IsAlive)
                {
                    meleeTeam.Remove(meleeCharacter);
                    continue;
                }
            }

            Console.WriteLine($"{Environment.NewLine}GAME OVER");
        }

        static void Fight(Character attacker, Character defender)
        {
            var isSpecialAttack = new Random().Next(3) < 1;

            (string, int) attack = isSpecialAttack ? attacker.SpecialAttack() : attacker.Attack();

            attacker.LevelUp(defender.TakeDamage(attack, attacker.Name));
        }
    }
}
