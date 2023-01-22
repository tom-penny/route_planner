using RoutePlanner.Extensions;
using static System.ConsoleColor;

namespace RoutePlanner.Helpers;

public struct ColorString
{
    public ColorString(string text, ConsoleColor foreground = White, ConsoleColor background = Black)
    {
        Text = text;
        Foreground = foreground;
        Background = background;
    }
    public ColorString(string text, int padding, ConsoleColor foreground = White, ConsoleColor background = Black)
    {
        Text = text.Pad(padding);
        Foreground = foreground;
        Background = background;
    }

    public string Text { get; set; }
    public ConsoleColor Foreground { get; }
    public ConsoleColor Background { get; }

    public void Write()
    {
        Console.ForegroundColor = Foreground;
        Console.BackgroundColor = Background;
        Console.Write(Text);
        Console.ResetColor();
    }
    public static void Write(params ColorString[] input)
    {
        foreach (var colorString in input)
        {
            colorString.Write();
        }
    }
    public static void Write(char separator, params ColorString[] input)
    {
        for (var i = 0; i < input.Length; i++)
        {
            input[i].Write();
            if (i < input.Length - 1) Console.Write(separator);
        }
    }
}