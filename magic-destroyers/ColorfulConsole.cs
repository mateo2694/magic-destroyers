using MagicDestroyers.Enums;

namespace MagicDestroyers
{
    public static class ColorfulConsole
    {
        public static void WriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void WriteLine(string message, Faction faction)
        {
            var color = faction switch
            {
                Faction.Melee => ConsoleColor.Magenta,
                Faction.Spellcasters => ConsoleColor.Cyan,
                _ => ConsoleColor.Gray
            };

            WriteLine(message, color);
        }
    }
}
