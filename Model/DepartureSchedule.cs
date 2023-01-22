using RoutePlanner.Model.Entities;
using System.Timers;

namespace RoutePlanner.Model;

public class DepartureSchedule
{
    private static readonly System.Timers.Timer Clock = new(10000);
    private static readonly TimeSpan Interval = new(00, 00, 10);
    private static readonly TimeSpan AtPlatform = new(00, 01, 00);
    private readonly Connection _connection;

    private TimeSpan _elapsed = TimeSpan.Zero;

    public DepartureSchedule(Connection connection)
    {
        _connection = connection;
        Clock.Elapsed += OnElapsed;
        Clock.Start();
    }

    public TimeSpan this[int index] => GetDeparture() * (index + 1) - _elapsed;

    private TimeSpan GetDeparture()
    {
        return _connection.Duration + AtPlatform;
    }

    private void OnElapsed(object? source, ElapsedEventArgs e)
    {
        _elapsed += Interval;
        if (_elapsed > GetDeparture())
        {
            _elapsed = TimeSpan.Zero;
        }
    }
}