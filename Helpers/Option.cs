namespace RoutePlanner.Helpers;

public class Option<T>
{
    public string Name { get; }
    public Func<T> Function { get; }

    public Option(string name, Func<T> function)
    {
        Name = name;
        Function = function;
    }

    public T Invoke() => Function();
    public override string ToString()
    {
        return Name;
    }
}

public class ControllerOption : Option<bool>
{
    public ControllerOption(string name, Func<bool> function) : base(name, function) { }
}