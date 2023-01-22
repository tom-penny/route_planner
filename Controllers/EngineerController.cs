using RoutePlanner.Helpers;

namespace RoutePlanner.Controllers;

public class EngineerController : Controller
{
    private readonly IController _networkMonitor;
    private readonly IController _connectionManager;
    private readonly IController _stationManager;

    public EngineerController(IController networkMonitor, IController connectionManager, IController stationManager)
    {
        _networkMonitor = networkMonitor;
        _connectionManager = connectionManager;
        _stationManager = stationManager;
        Options = CreateOptions();
    }

    protected override ControllerOption[] CreateOptions() => new[]
    {
        new ControllerOption("View Disruptions", ViewDisruptions),
        new ControllerOption("Manage Connections", ManageConnections),
        new ControllerOption("Manage Stations", ManageStations),
        new ControllerOption("Go Back", Return)
    };

    private bool ViewDisruptions()
    {
        _networkMonitor.Initiate();
        return false;
    }
    private bool ManageConnections()
    {
        _connectionManager.Initiate();
        return false;
    }
    private bool ManageStations()
    {
        _stationManager.Initiate();
        return false;
    }
}