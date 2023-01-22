using RoutePlanner.Model.DataAccess;
using RoutePlanner.Model.Entities;

namespace RoutePlanner.Model.Algorithms;

public delegate Dictionary<Station, Connection> RouteAlgorithm(Station origin);

public interface IRouteFinder
{
    RouteAlgorithm GetRoute();
}

public class RouteFinder : IRouteFinder
{
    private Dictionary<Station, TimeSpan>? _distanceTo;
    private Dictionary<Station, Connection>? _edgeTo;
    private PriorityQueue<Station, TimeSpan>? _queue;

    public RouteAlgorithm GetRoute()
    {
        return ShortestPath;
    }

    private Dictionary<Station, Connection> ShortestPath(Station source)
    {
        _distanceTo = new Dictionary<Station, TimeSpan>();
        _edgeTo = new Dictionary<Station, Connection>();
        _queue = new PriorityQueue<Station, TimeSpan>();
        foreach (var station in DataContext.Stations)
        {
            if (station == source) _distanceTo.Add(source, TimeSpan.Zero);
            else _distanceTo.Add(station, TimeSpan.MaxValue);
        }
        _queue.Enqueue(source, TimeSpan.Zero);
        while (_queue.Count > 0)
        {
            var next = _queue.Dequeue();
            var connection = next.Connections.First;
            for (var i = 0; i < next.Connections.Count; i++)
            {
                Relax(connection.Value);
                connection = connection.Next;
            }
        }
        return _edgeTo;
    }

    private void Relax(Connection connection)
    {
        if (connection.IsClosed) return;
        var edge = connection.Destination.IsClosed ? GetNext(connection) : connection;
        if (edge == null) return;
        var origin = edge.Origin;
        var destination = edge.Destination;
        var duration = edge.Duration;
        if (_edgeTo!.TryGetValue(origin, out var prev) && !prev.Platform.Equals(edge.Platform))
        {
            duration += new TimeSpan(00, 02, 00);
        }
        if (_distanceTo![destination] > _distanceTo[origin] + duration)
        {
            _distanceTo[destination] = _distanceTo[origin] + edge.Duration;
            _edgeTo[destination] = edge;
            _queue!.Enqueue(destination, _distanceTo[destination]);
        }
    }
    private Connection? GetNext(Connection connection)
    {
        var forward = GetForward(connection);
        if (forward == null) return null;
        var duration = connection.Duration + forward.Duration;
        return new Connection(connection.Origin, forward.Destination, connection.Line, connection.Platform.Direction, duration);
    }
    private Connection? GetForward(Connection connection)
    {
        var connections = connection.Destination.Connections;
        return connections.FirstOrDefault(c => c.Platform.Equals(connection.Platform) && !c.Equals(connection));
    }
}