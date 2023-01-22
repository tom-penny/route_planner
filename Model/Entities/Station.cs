using RoutePlanner;
using RoutePlanner.Extensions;

namespace RoutePlanner.Model.Entities;

public class Station : IComparable<Station>, IEquatable<Station>, ITraversable
{
    private bool _isClosed;

    public Station(string name, Zone zone)
    {
        Name = name;
        Zone = zone;
    }

    public string Name { get; }
    public Zone Zone { get; }
    public bool IsClosed
    {
        get => _isClosed ^ !Hours.InService();
        set => _isClosed = value;
    }
    public ServiceHours Hours => ServiceHours.Regular;
    public LinkedList<Connection> Connections { get; } = new();
    public HashSet<TubeLine> Lines { get; } = new();

    public void AddConnection(Station destination, TubeLine line, Direction direction, TimeSpan duration)
    {
        Connections.AddLast(new Connection(this, destination, line, direction, duration));
        Lines.Add(line);
    }
    public void AddConnection(Station destination, TubeLine line, Direction direction, double mins)
    {
        Connections.AddLast(new Connection(this, destination, line, direction, TimeSpan.FromMinutes(mins)));
        Lines.Add(line);
    }

    public int CompareTo(Station? other)
    {
        return other is { } ? string.Compare(Name, other.Name, StringComparison.Ordinal) : 1;
    }

    public override string ToString()
    {
        return Name;
    }

    public bool Equals(Station? other)
    {
        return other is { } && Name.Equals(other.Name);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}