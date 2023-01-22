namespace RoutePlanner.Controllers.Input;

public abstract class InputReader<T>
{
    protected abstract T Output { get; }

    protected abstract void ParseKey(ref ConsoleKeyInfo keypress);
    protected T RunInput()
    {
        ConsoleKeyInfo keypress;
        do
        {
            while (!Console.KeyAvailable) { }
            keypress = Console.ReadKey(true);
            ParseKey(ref keypress);
        } while (keypress.Key != ConsoleKey.Enter);
        return Output;
    }
}