using RoutePlanner.Extensions;
using RoutePlanner.Helpers;

namespace RoutePlanner.Controllers;

public interface IController
{
    void Initiate();
}

public abstract class Controller : IController
{
    protected ControllerOption[] Options;

    public virtual void Initiate()
    {
        while (!SelectOption().Invoke()) { }
    }

    protected abstract ControllerOption[] CreateOptions();
    protected ControllerOption SelectOption()
    {
        return UserSelection.SelectElement(Options, "Select Option:").ThrowIfNull()!;
    }
    protected bool Return()
    {
        return true;
    }
}


public class MenuController
{
    protected ControllerOption[] Options;

    public MenuController(params (string, Func<bool>)[] options)
    {
        Options = new ControllerOption[options.Length];
        for (var i = 0; i < options.Length; i++)
        {
            Options[i] = new ControllerOption(options[i].Item1, options[i].Item2);
        }
    }

    public virtual void Initiate()
    {
        while (!SelectOption().Invoke()) { }
    }

    protected ControllerOption SelectOption()
    {
        return UserSelection.SelectElement(Options, "Select Option:").ThrowIfNull()!;
    }
}
