using RoutePlanner;
using RoutePlanner.Extensions;
using RoutePlanner.Helpers;

namespace RoutePlanner.Controllers.Input;

public class FieldReader : InputReader<string>
{
    private readonly StringWriter _writer;
    private readonly CharacterType _type;
    private readonly string _prompt;
    private readonly bool _spaces;
    private readonly bool _reverse;

    private FieldReader(StringWriter writer, CharacterType type, string prompt, bool spaces, bool reverse)
    {
        _writer = writer;
        _type = type;
        _prompt = prompt;
        _spaces = spaces;
        _reverse = reverse;
    }

    protected override string Output => _reverse ? _writer.ToString().Reverse() : _writer;

    public static string Read(CharacterType type, int limit, string prompt, bool spaces = false, bool reverse = false)
    {
        var reader = new FieldReader(new StringWriter(limit), type, prompt, spaces, reverse);
        reader.DisplayKeys();
        return reader.RunInput();
    }
    public static string Read(CharacterType type, int limit, string prompt, bool spaces = false, bool reverse = false,
        params (int position, char c)[] fixedChars)
    {
        var reader = new FieldReader(new StringWriter(limit, fixedChars), type, prompt, spaces, reverse);
        reader.DisplayKeys();
        return reader.RunInput();
    }

    protected override void ParseKey(ref ConsoleKeyInfo keypress)
    {
        switch (keypress)
        {
            case { Key: ConsoleKey.Backspace }: _writer.Truncate(); break;
            case { Key: ConsoleKey.Enter } when _writer.IsEmpty: keypress = new ConsoleKeyInfo(); break;
            default: AddChar(keypress.KeyChar); break;
        }
        DisplayKeys();
    }

    private void AddChar(char keyChar)
    {
        if (_type.Validate(keyChar) && keyChar != ' ') _writer.Append(keyChar);
        if (_spaces && keyChar == ' ') _writer.Append(keyChar);
    }
    private void DisplayKeys()
    {
        Console.Clear();
        ColorString.Write(' ', new ColorString(_prompt, ConsoleColor.Cyan), new ColorString(Output));
    }
}