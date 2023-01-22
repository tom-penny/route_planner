using RoutePlanner.Extensions;
using RoutePlanner.Helpers;
using RoutePlanner.Model.DataAccess;
using RoutePlanner.Model.Entities;

namespace RoutePlanner.Controllers;

public class StationManager : Controller
{
    private readonly ISelector<Station> _stationSelector;
    private Station? _station;
    public StationManager(ISelector<Station> stationSelector)
    {
        _stationSelector = stationSelector;
        Options = CreateOptions();
    }

    public override void Initiate()
    {
        _station = _stationSelector.Select();
        base.Initiate();
    }

    protected override ControllerOption[] CreateOptions() => new[]
    {
        new ControllerOption("Set Station Status", SetStatus),
        new ControllerOption("Go Back", Return)
    };

    private bool SetStatus()
    {
        var confirm = UserSelection.SelectBool("Set Line Status:", $"{(_station!.IsClosed ? "Open" : "Close")} Station", "Go Back");
        if (!confirm) return false;
        _station.IsClosed = !_station.IsClosed;
        $"{_station.Name} is now {(_station.IsClosed ? "closed" : "open")}.".ToConsole(1500);
        return false;
    }
}