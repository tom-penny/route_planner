using RoutePlanner.Model.Entities;

namespace RoutePlanner.Model.DataAccess;

public static class DataContext
{
    public static SortedSet<Station> Stations { get; } = new();

    public static Station Add(Station station)
    {
        return Stations.Add(station) ? station : throw new NullReferenceException();
    }
}