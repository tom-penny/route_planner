using RoutePlanner;
using RoutePlanner.Extensions;
using RoutePlanner.Helpers;
using RoutePlanner.Model.Entities;

namespace RoutePlanner.Model.DataAccess;

public interface ISelector<out T>
{
    T Select();
}

public class StationSelector : ISelector<Station>
{
    private readonly StationFilter _filter;

    public StationSelector(StationFilter filter)
    {
        _filter = filter;
    }

    public Station Select()
    {
        return UserSelection.SelectElement(_filter.GetStations(), "Select Station:");
    }
}

public class StationFilter
{
    private readonly Option<Station[]>[] _options;

    public StationFilter(IStationFilterStrategy lineStrategy, IStationFilterStrategy nameStrategy, IStationFilterStrategy zoneStrategy)
    {
        _options = new[]
        {
            new Option<Station[]>("Search by Line", lineStrategy.Filter),
            new Option<Station[]>("Search by Name", nameStrategy.Filter),
            new Option<Station[]>("Search by Zone", zoneStrategy.Filter)
        };
    }

    public Station[] GetStations()
    {
        return UserSelection.SelectElement(_options, "Select Station:").Invoke();
    }
}

public interface IStationFilterStrategy
{
    Station[] Filter();
}

public abstract class StationFilterStrategy<T> : IStationFilterStrategy
{
    public abstract Station[] Filter();

    protected abstract T GetFilter();
}

public class ZoneFilterStrategy : StationFilterStrategy<Zone>
{
    private static Zone[] Zones { get; } = (Zone[])Enum.GetValues(typeof(Zone));

    public override Station[] Filter()
    {
        var filter = GetFilter();
        return DataContext.Stations.Where(s => s.Zone.Equals(filter)).ToArray();
    }

    protected override Zone GetFilter()
    {
        return UserSelection.SelectElement(Zones);
    }
}

public class LineFilterStrategy : StationFilterStrategy<TubeLine>
{
    private static TubeLine[] Lines { get; } = (TubeLine[])Enum.GetValues(typeof(TubeLine));

    public override Station[] Filter()
    {
        var filter = GetFilter();
        return DataContext.Stations.Where(s => s.Lines.Contains(filter)).ToArray();
    }

    protected override TubeLine GetFilter()
    {
        return UserSelection.SelectElement(Lines);
    }
}

public class NameFilterStrategy : StationFilterStrategy<string>
{
    private readonly string[] _letters = { "A-C", "D-F", "G-I", "J-L", "M-O", "P-R", "S-U", "V-Z" };

    public override Station[] Filter()
    {
        Func<char, bool> func = GetFilter() switch
        {
            "A-C" => CharExtensions.A_C,
            "D-F" => CharExtensions.D_F,
            "G-I" => CharExtensions.G_I,
            "J-L" => CharExtensions.J_L,
            "M-O" => CharExtensions.M_O,
            "P-R" => CharExtensions.P_R,
            "S-U" => CharExtensions.S_U,
            "V-Z" => CharExtensions.V_Z
        };
        return DataContext.Stations.Where(s => func(s.Name[0])).ToArray();
    }

    protected override string GetFilter()
    {
        return UserSelection.SelectElement(_letters, "View Stations From:");
    }
}