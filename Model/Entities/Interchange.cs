using RoutePlanner.Extensions;

namespace RoutePlanner.Model.Entities;

public class Interchange : Traversal
{
    public Interchange(Platform origin, Platform destination, Station via)
    {
        Origin = origin;
        Destination = destination;
        Via = via;
    }

    public override Platform Origin { get; }
    public override Platform Destination { get; }
    public override Station Via { get; }
    public override TimeSpan Duration { get; } = new(00, 02, 00);

    public override string ToString()
    {
        var transit = $"{Origin} to {Destination}";
        return $"{transit,-60}{Duration.ToMinutes(),5}mins";
    }
}