using RoutePlanner.Extensions;

namespace RoutePlanner.Model.Entities;

public class TrainLeg : Traversal
{
    public TrainLeg(Station origin, Station destination, Platform via, TimeSpan duration)
    {
        Origin = origin;
        Destination = destination;
        Via = via;
        Duration = duration;
    }

    public override Station Origin { get; }
    public override Station Destination { get; }
    public override Platform Via { get; }
    public override TimeSpan Duration { get; }

    public override string ToString()
    {
        var transit = $"{Via}: {Origin} to {Destination}";
        return $"{transit,-60}{Duration.ToMinutes(),5}mins";
    }
}