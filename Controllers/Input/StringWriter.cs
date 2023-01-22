using System.Text;

namespace RoutePlanner.Controllers.Input;

public class StringWriter
{
    private readonly SortedList<int, char> _fixedChars = new();
    private readonly StringBuilder _sb = new();
    private readonly int _charLimit;

    public StringWriter(int charLimit)
    {
        _charLimit = charLimit;
    }
    public StringWriter(int charLimit, params (int position, char c)[] fixedChars)
    {
        _charLimit = charLimit;
        foreach (var (position, c) in fixedChars)
        {
            _fixedChars.Add(position, c);
        }
    }

    public int Length => _sb.Length;
    public bool IsEmpty => _sb.Length < 1;

    public static implicit operator string(StringWriter other)
    {
        return other.ToString();
    }

    public void Append(char c)
    {
        if (Length >= _charLimit) return;
        _sb.Append(c);
        AppendFixed();
    }
    public void Truncate()
    {
        switch (Length)
        {
            case < 1: return;
            case > 1 when _fixedChars.ContainsKey(Length): _sb.Length -= 2; return;
            default: _sb.Length--; return;
        }
        //if (Length < 1) return;
        //if (Length > 1 && _fixedChars.ContainsKey(Length)) _sb.Length -= 2;
        //else _sb.Length--;
    }
    public override string ToString()
    {
        return _sb.ToString();
    }

    private void AppendFixed()
    {
        if (_fixedChars.TryGetValue(Length + 1, out var value))
        {
            _sb.Append(value);
        }
    }
}