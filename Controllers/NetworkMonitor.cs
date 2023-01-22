using RoutePlanner.Extensions;
using RoutePlanner.Helpers;
using RoutePlanner.Model.DataAccess;
using RoutePlanner.Views;

namespace RoutePlanner.Controllers;

public class NetworkMonitor : Controller
{
    private readonly IViewer _closureViewer;
    private readonly IViewer _delayViewer;
    private MenuController _menuController;

    public NetworkMonitor(IViewer closureViewer, IViewer delayViewer)
    {
        _closureViewer = closureViewer;
        _delayViewer = delayViewer;
        _menuController = new MenuController(("Display Closures", DisplayClosures), ("Display Delays", DisplayDelays), ("Go Back", Return));
        Options = CreateOptions();
    }

    public override void Initiate()
    {
        _menuController.Initiate();
    }

    protected override ControllerOption[] CreateOptions() => new[]
    {
        new ControllerOption("Display Closures", DisplayClosures),
        new ControllerOption("Display Delays", DisplayDelays),
        new ControllerOption("Go Back", Return)
    };

    private bool DisplayClosures()
    {
        _closureViewer.Display();
        return false;
    }

    private bool DisplayDelays()
    {
        _delayViewer.Display();
        return false;
    }
}


public class ClosureViewer : DisplayViewer
{
    private readonly ConnectionRepository _connections;

    public ClosureViewer(ConnectionRepository connections)
    {
        _connections = connections;
    }

    public override void Display()
    {
        Console.Clear();
        DisplayElements.Header(DisplayWidth, "Track Closures", ConsoleColor.White);
        var closures = _connections.GetClosed();
        if (!closures.Any()) Console.WriteLine("All tracks are open.");
        else
        {
            foreach (var closure in closures)
            {
                Console.WriteLine($"{closure,-65}{":",-5}{closure.GetStatus()}");
            }
        }
        true.AwaitKey();
    }
}
public class DelayViewer : DisplayViewer
{
    private readonly ConnectionRepository _connections;

    public DelayViewer(ConnectionRepository connections)
    {
        _connections = connections;
    }

    public override void Display()
    {
        Console.Clear();
        DisplayElements.Header(DisplayWidth, "Track Delays", ConsoleColor.White);
        var delays = _connections.GetDelayed();
        if (!delays.Any()) Console.WriteLine("All tracks are running on time.");
        else
        {
            foreach (var delay in delays)
            {
                Console.WriteLine($"{delay,-65}{":",-5}{delay.GetDuration()}");

            }
        }
        true.AwaitKey();
    }
}