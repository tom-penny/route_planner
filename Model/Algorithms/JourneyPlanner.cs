using RoutePlanner.Model.Entities;

namespace RoutePlanner.Model.Algorithms;

public class JourneyPlanner
{
    private Dictionary<Station, Connection>? _edgeTo;
    private readonly IRouteFinder _routeFinder;

    public JourneyPlanner(IRouteFinder routeFinder)
    {
        _routeFinder = routeFinder;
    }

    public Journey? GetJourney(Station origin, Station destination)
    {
        var algorithm = _routeFinder.GetRoute();
        _edgeTo = algorithm(origin);
        if (!_edgeTo.TryGetValue(destination, out var result)) return null;
        return new Journey(origin, destination, TraceRoute(origin, destination));
    }

    private Stack<ITraversal> TraceRoute(Station origin, Station destination)
    {
        var stack = new Stack<ITraversal>();
        var duration = TimeSpan.Zero;
        var end = destination;
        var platform = _edgeTo[end].Platform;
        do
        {
            var edge = _edgeTo[destination];
            if (!edge.Platform.Equals(platform))
            {
                stack.Push(new TrainLeg(destination, end, platform, duration));
                stack.Push(new Interchange(edge.Platform, platform, destination));
                platform = edge.Platform;
                end = destination;
                duration = TimeSpan.Zero;
                continue;
            }
            duration += edge.Duration;
            destination = edge.Origin;
        } while (!destination.Equals(origin));
        stack.Push(new TrainLeg(origin, end, platform, duration));
        return stack;
    }
}