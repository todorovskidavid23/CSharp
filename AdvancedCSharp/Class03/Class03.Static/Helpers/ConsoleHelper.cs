using System;
using System.Collections.Generic;
using System.Text;

namespace Class03.Static.Helpers
{
    public static class ConsoleHelper//DA SI bide static site nejzini lenovi da bidat static
    {
        public static void WriteInColor(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
