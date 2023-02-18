using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;

namespace MagicDestroyers
{
    class Program
    {
        static void Main()
        {
            bool gameOver = false;

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                new Mage(),
                new Mage(),
                new Mage(),
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

            while (!gameOver)
            {
                // 1. Take random Melee

                // 2. Take random Spellcaster

                // 3. Melee attacks Spellcaster
                // 3.1 If character died remove it from team
                // 3.2 If dead get a new character from team

                // 4. Spellcaster attacks Melee
                // 4.1 If character died remove it from team
                // 4.2 If dead get a new character from team

                // 5. If all members of a team die gameOver = true
            }
        }
    }
}
