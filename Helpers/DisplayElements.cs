using RoutePlanner.Extensions;

namespace RoutePlanner.Helpers;

public static class DisplayElements
{
    public static void Header(int width, string heading, ConsoleColor color, bool escape = true)
    {
        RowFull(width, color, true, '_');
        RowFull(width, color, true, '▒');
        RowFull(width, $" {heading} ", color, true, '▒');
        RowFull(width, color, true, '▒');
        Console.Write(escape ? "\n" : "");
    }

    public static void SubHeader(int width, string heading, ConsoleColor color, bool escape = true)
    {
        RowFull(width, $" {heading} ", color, true, '─');
        Console.Write(escape ? "\n" : "");
    }

    public static void EndLine(int width, ConsoleColor color, bool escape = true)
    {
        RowFull(width, color, true, '─');
        Console.Write(escape ? "\n" : "");
    }


    public static void RowFull(int width, ConsoleColor color, bool escape = true, char c = '▓')
    {
        "".PadLeft(width, c).WriteColor(color);
        Console.Write(escape ? "\n" : "");
    }

    public static void RowFull(int width, string text, ConsoleColor color, bool escape = true, char c = '▓')
    {
        var odd = text.Length % 2 != 0;
        "".PadLeft(width / 2 - text.Length / 2, c).WriteColor(color);
        text.WriteColor(color);
        "".PadRight(width / 2 - text.Length / 2 - (odd ? 1 : 0), c).WriteColor(color);
        Console.Write(escape ? "\n" : "");
    }
    public static void RowSplit(int leftWidth, int rightWidth, bool escape, ConsoleColor leftColor, ConsoleColor rightColor, char c = '▓')
    {
        RowFull(leftWidth, leftColor, false, c);
        RowFull(rightWidth, rightColor, escape, c);
    }
    public static void BorderHorizontal(VerticalPosition point, int innerWidth)
    {
        Console.Write(point == VerticalPosition.Lower ? "╚" : "╔");
        RowFull(innerWidth, ConsoleColor.White, false, '═');
        Console.Write(point == VerticalPosition.Lower ? "╝" : "╗");
    }
}
