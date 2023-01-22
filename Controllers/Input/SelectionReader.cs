namespace RoutePlanner.Controllers.Input;

public class SelectionReader<T> : InputReader<int>
{
    private readonly Navigator<T> _navigator;

    private SelectionReader(Navigator<T> navigator)
    {
        _navigator = navigator;
    }

    protected override int Output => _navigator.Selection;

    public static int Read(T[] options, string prompt)
    {
        var reader = new SelectionReader<T>(new Navigator<T>(options, prompt));
        return reader.RunInput();
    }

    protected override void ParseKey(ref ConsoleKeyInfo keypress)
    {
        _navigator.Navigate(keypress);
    }
}