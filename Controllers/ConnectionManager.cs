using RoutePlanner.Helpers;
using RoutePlanner;
using RoutePlanner.Model.Entities;
using RoutePlanner.Extensions;
using RoutePlanner.Model.DataAccess;

namespace RoutePlanner.Controllers;

public class ConnectionManager : Controller
{
    private readonly ISelector<Connection> _connectionSelector;
    private Connection? _connection;

    public ConnectionManager(ISelector<Connection> connectionSelector)
    {
        _connectionSelector = connectionSelector;
        Options = CreateOptions();
    }

    public override void Initiate()
    {
        _connection = _connectionSelector.Select();
        base.Initiate();
    }

    protected override ControllerOption[] CreateOptions() => new[]
    {
        new ControllerOption("Set Status", SetStatus),
        new ControllerOption("Set Delay", SetDelay),
        new ControllerOption("Go Back", Return)
    };

    private bool SetStatus()
    {
        var confirm = UserSelection.SelectBool("Set Status:", $"{(_connection!.IsClosed ? "Open" : "Close")} Connection", "Go Back");
        if (!confirm) return false;
        _connection.IsClosed = !_connection.IsClosed;
        $"{_connection} is now {(_connection.IsClosed ? "closed" : "open")}.".ToConsole(1500);
        return false;
    }
    private bool SetDelay()
    {
        _connection.Delay = UserInput.Read<TimeSpan>(InputType.Time);
        return false;
    }
}