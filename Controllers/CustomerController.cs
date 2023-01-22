using RoutePlanner.Helpers;
using RoutePlanner.Views;

namespace RoutePlanner.Controllers;

public class CustomerController : Controller
{
    private readonly IViewer _stationViewer;
    private readonly IViewer _journeyViewer;

    public CustomerController(IViewer stationViewer, IViewer journeyViewer)
    {
        _stationViewer = stationViewer;
        _journeyViewer = journeyViewer;
        Options = CreateOptions();
    }

    protected override ControllerOption[] CreateOptions() => new[]
    {
        new ControllerOption("Search Stations", SearchStation),
        new ControllerOption("Plan Journey", PlanJourney),
        new ControllerOption("Go Back", Return)
    };

    private bool SearchStation()
    {
        _stationViewer.Display();
        return false;
    }
    private bool PlanJourney()
    {
        _journeyViewer.Display();
        return false;
    }
}