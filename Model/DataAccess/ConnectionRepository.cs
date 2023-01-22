using RoutePlanner;
using RoutePlanner.Model.Entities;

namespace RoutePlanner.Model.DataAccess;

public class ConnectionRepository
{
    public IEnumerable<Connection> GetByLine(TubeLine line)
    {
        return DataContext.Stations.Select(s => s.Connections.Where(c => c.Line.Equals(line))).SelectMany(e => e);
    }
    public IEnumerable<Connection> GetClosed()
    {
        return DataContext.Stations.Select(s => s.Connections.Where(c => c.IsClosed)).SelectMany(e => e);
    }
    public IEnumerable<Connection> GetDelayed()
    {
        return DataContext.Stations.Select(s => s.Connections.Where(c => c.IsDelayed)).SelectMany(e => e);
    }
}