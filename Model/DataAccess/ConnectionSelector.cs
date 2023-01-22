using RoutePlanner.Helpers;
using RoutePlanner.Model.Entities;

namespace RoutePlanner.Model.DataAccess;

public class ConnectionSelector : ISelector<Connection>
{
    private readonly ISelector<Station> _stationSelector;

    public ConnectionSelector(ISelector<Station> stationSelector)
    {
        _stationSelector = stationSelector;
    }

    public Connection Select()
    {
        var origin = _stationSelector.Select();
        return UserSelection.SelectElement(origin.Connections);
    }
}