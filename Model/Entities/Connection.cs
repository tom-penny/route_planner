using RoutePlanner;
using RoutePlanner.Extensions;
using RoutePlanner.Model;

namespace RoutePlanner.Model.Entities;

public class Connection : IComparable<Connection>
{
    private readonly TimeSpan _duration;
    public Connection(Station origin, Station destination, TubeLine line, Direction direction, TimeSpan duration)
    {
        Origin = origin;
        Destination = destination;
        Platform = new Platform(line, direction);
        _duration = duration;
        Schedule = new DepartureSchedule(this);
    }

    public Station Origin { get; }
    public Station Destination { get; }
    public Platform Platform { get; }
    public DepartureSchedule Schedule { get; }
    public TubeLine Line => Platform.Line;
    public TimeSpan Duration => Delay > TimeSpan.Zero ? _duration + Delay : _duration;
    public bool IsDelayed => Duration > _duration;

    public TimeSpan Delay { get; set; }
    public bool IsClosed { get; set; }

    public string GetStatus()
    {
        return IsClosed ? "Closed" : "Open";
    }
    public string GetDuration()
    {
        return $"{_duration.ToMinutes()}mins{(IsDelayed ? $" (Delayed {Delay.ToMinutes()}mins)" : "")}";
    }
    public int CompareTo(Connection? other)
    {
        var result = Origin.CompareTo(other.Origin);
        result = result switch
        {
            0 => Destination.CompareTo(other.Destination),
            _ => result
        };
        return result;
    }
    public override string ToString()
    {
        return $"{Platform}: {Origin} to {Destination}";
    }
}