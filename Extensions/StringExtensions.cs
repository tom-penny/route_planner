namespace RoutePlanner.Extensions;

public static class StringExtensions
{
    public static string Pad(this string input, int padding) => padding switch
    {
        < 0 => input.PadRight(padding * -1),
        > 0 => input.PadLeft(padding),
        _ => input
    };
    public static string PadEqual(this string input, int total, char paddingChar = ' ')
    {
        var padding = total - input.Length;
        var left = padding / 2 + input.Length;
        return input.PadLeft(left, paddingChar).PadRight(total, paddingChar);
    }
    public static void ToConsole(this string input, bool await = false)
    {
        Console.Clear();
        Console.WriteLine(input);
        await.AwaitKey();
    }

    public static void ToConsole(this string input, int pause)
    {
        Console.Clear();
        Console.WriteLine(input);
        Thread.Sleep(pause);
    }
    public static string Reverse(this string input)
    {
        var chars = new char[input.Length];
        for (var i = 0; i < chars.Length; i++)
        {
            chars[i] = input[i];
        }
        Array.Reverse(chars);
        return new string(chars);
    }
    public static void WriteColor(this string input, ConsoleColor foreground, ConsoleColor background = ConsoleColor.Black)
    {
        Console.ForegroundColor = foreground;
        Console.BackgroundColor = background;
        Console.Write(input);
        Console.ResetColor();
    }
    public static void WriteLineColor(this string input, ConsoleColor foreground, ConsoleColor background = ConsoleColor.Black)
    {
        Console.ForegroundColor = foreground;
        Console.BackgroundColor = background;
        Console.Write(input);
        Console.ResetColor();
        Console.Write("\n");
    }
}