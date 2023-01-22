using RoutePlanner;
using RoutePlanner.Model.DataAccess;

namespace RoutePlanner.Model;

public class StatusMonitor
{
    private readonly ConnectionRepository _connections;

    public StatusMonitor(ConnectionRepository connections)
    {
        _connections = connections;
    }

    public string GetLineStatus(TubeLine line)
    {
        var connections = _connections.GetByLine(line);
        var lines = connections.Count();
        var delays = connections.Count(c => c.IsDelayed);
        return GetStatus(delays, lines);
    }

    private string GetStatus(int count, int total) => (count / total * 100) switch
    {
        < 10 => "Good Service",
        < 25 => "Minor Delays",
        _ => "Severe Delays",
    };
}