using RoutePlanner.Extensions;
using RoutePlanner.Helpers;

namespace RoutePlanner.Controllers.Input;

public class Navigator<T>
{
    private readonly T[] _options;
    private readonly string _prompt;
    private int _selection = -1;

    public Navigator(T[] options, string prompt)
    {
        _options = options;
        _prompt = prompt;
        Selection = 0;
    }

    public int Selection
    {
        get => _selection;
        set
        {
            if (_selection == value) return;
            _selection = FilterSelection(value);
            Render(_options, _prompt);
        }
    }

    public void Navigate(ConsoleKeyInfo keypress)
    {
        switch (keypress)
        {
            case { Key: ConsoleKey.UpArrow }: Selection--; return;
            case { Key: ConsoleKey.DownArrow }: Selection++; return;
        }
    }

    private int FilterSelection(int value)
    {
        if (value <= -1) return _options.Length - 1;
        return value == _options.Length ? 0 : value;
    }
    private void Render(T[] options, string prompt)
    {
        Console.Clear();
        DisplayElements.Header(100, prompt, ConsoleColor.White);
        Console.WriteLine();
        for (var i = 0; i < options.Length; i++)
        {
            if (i == _selection) $" {options[i]} ".PadEqual(100, '-').WriteLineColor(ConsoleColor.Black, ConsoleColor.Cyan);
            else { $" {options[i]} ".PadEqual(100).WriteLineColor(ConsoleColor.White); }
        }
    }
}