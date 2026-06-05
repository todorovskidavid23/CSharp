using System;
using System.Collections.Generic;
using System.Text;

namespace Class10.Helpers
{
    public static void PrintInColor(string text, ConsoleColor color = ConsoleColor.Blue)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void PrintError(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}
