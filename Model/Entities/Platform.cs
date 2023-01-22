namespace RoutePlanner.Model.Entities;

public class Platform : IComparable<Platform>, ITraversable, IEquatable<Platform>
{
    public Platform(TubeLine line, Direction direction)
    {
        Line = line;
        Direction = direction;
    }

    public TubeLine Line { get; }
    public Direction Direction { get; }

    public int CompareTo(Platform? other)
    {
        var result = Line.CompareTo(other.Line);
        result = result switch
        {
            0 => Direction.CompareTo(other.Direction),
            _ => result
        };
        return result;
    }
    public override string ToString()
    {
        return $"{Line}({Direction})";
    }

    public bool Equals(Platform? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Line == other.Line && Direction == other.Direction;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Platform)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Line, (int)Direction);
    }
}