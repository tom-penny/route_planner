using RoutePlanner;
using RoutePlanner.Extensions;
using RoutePlanner.Helpers;
using RoutePlanner.Model;
using RoutePlanner.Model.DataAccess;
using RoutePlanner.Model.Entities;
using static System.ConsoleColor;

namespace RoutePlanner.Views;

public class StationViewer : DisplayViewer
{
    private readonly ISelector<Station> _stationSelector;
    private readonly StatusMonitor _statusMonitor;

    private Station? _station;

    public StationViewer(ISelector<Station> stationSelector, StatusMonitor statusMonitor)
    {
        _stationSelector = stationSelector;
        _statusMonitor = statusMonitor;
    }

    public override void Display()
    {
        _station = _stationSelector.Select();
        while (Console.KeyAvailable == false)
        {
            DisplayInfo();
            Console.WriteLine("\nPress any key to continue.");
            var count = 0;
            while (count < 30)
            {
                Thread.Sleep(500);
                if (Console.KeyAvailable) return;
                count++;
            }
        }
    }

    private void DisplayInfo()
    {
        Console.Clear();
        DisplayElements.Header(DisplayWidth, _station.Name, White);
        Console.WriteLine($"  ({_station.Zone})");
        DisplayElements.RowFull(DisplayWidth, White, true, '─');
        PrintCrowding();
        Console.WriteLine();
        PrintLines();
        PrintDepartures();
    }
    private void PrintLines()
    {
        DisplayElements.SubHeader(DisplayWidth, "Lines at this station", White);
        var lines = _station.Lines;
        foreach (var line in lines)
        {
            PrintStatus(line);

        }
    }
    private void PrintStatus(TubeLine line)
    {
        var color = line.Color();
        var text = $"  {line}";
        var status = $"  {_statusMonitor.GetLineStatus(line)}";

        "".PadLeft(DisplayWidth / 2).WriteLineColor(color, color);
        text.PadRight(DisplayWidth / 2).WriteColor(color == Black ? White : Black, color);
        Console.Write($"{status}\n");
        "".PadLeft(DisplayWidth / 2).WriteLineColor(color, color);
        DisplayElements.RowFull(DisplayWidth, DarkGray, true, '─');
    }
    private void PrintCrowding()
    {
        var crowding = $"  (■) The station is usually {LineExtensions.AverageCrowding()} at this time.";
        "".PadLeft(DisplayWidth).WriteLineColor(Gray, Gray);
        crowding.PadRight(DisplayWidth).WriteLineColor(Black, Gray);
        "".PadLeft(DisplayWidth).WriteLineColor(Gray, Gray);
    }
    public void PrintDepartures()
    {
        DisplayElements.SubHeader(DisplayWidth, $"Live departures at {DateTime.UtcNow:T}", White);
        var node = _station.Connections.First;
        while (node is { Value: var connection })
        {
            var color = connection.Line.Color();
            for (var i = 0; i < 3; i++)
            {
                $" {i} ".WriteColor(color == Black ? White : Black, color);
                var departure = connection.Schedule[i];
                var expected = $"{(departure.Minutes < 1 ? "Due" : $"{departure.Minutes} {(departure.Minutes == 1 ? "min" : "mins")}")}";
                Console.Write($"  {connection.Platform,-80}{expected,8}\n");
            }
            DisplayElements.RowFull(DisplayWidth, DarkGray, true, '─');
            node = node.Next;
        }
    }
}




//public class StationFinder : IStationFinder
//{
//    private readonly FilterContext _filterContext;
//    private readonly Station[] _stations;

//    public Station GetStation()
//    {
//        return UserSelection.SelectElement(GetStations(_filterContext.GetFilter()));
//    }

//    private Station[] GetStations(string input)
//    {
//        var enumerable = _stations.Custom_AsEnumerable();
//        return enumerable.Custom_Where(s => s.Name.Contains(input, StringComparison.OrdinalIgnoreCase)).Custom_ToArray();
//    }
//    private Station[] GetStations(Zone zone)
//    {
//        var enumerable = _stations.Custom_AsEnumerable();
//        return enumerable.Custom_Where(s => s.Zone.Equals(zone)).Custom_ToArray();
//    }
//    private Station[] GetStations(Line line)
//    {
//        var enumerable = _stations.Custom_AsEnumerable();
//        return enumerable.Custom_Where(s => s.Line.Equals(line));
//    }
//}

//public class FilterContext
//{
//    //private readonly IFilterStrategy<Zone> _zoneFilter;
//    //private readonly IFilterStrategy<Line> _lineFilter;
//    //private readonly IFilterStrategy<string> _nameFilter;
//    private readonly Option<dynamic>[] Options;

//    public FilterContext(IFilterStrategy<Zone> zoneFilter, IFilterStrategy<Line> lineFilter, IFilterStrategy<string> nameFilter)
//    {
//        Options = new[]
//        {
//            new Option<dynamic>("Search by Zone", GetStrategy(zoneFilter)),
//            new Option<dynamic>("Search by Line", GetStrategy(lineFilter)),
//            new Option<dynamic>("Search by Name", GetStrategy(nameFilter))
//        };
//    }

//    public dynamic GetFilter()
//    {
//        return UserSelection.SelectElement(Options, "Select Option:").Invoke();
//    }

//    private dynamic GetStrategy<T>(IFilterStrategy<T> strategy) => strategy.GetFilter();
//}


//public interface IFilterStrategy<out T>
//{
//    T GetFilter();
//}

//public class ZoneFilterStrategy : IFilterStrategy<Zone>
//{
//    private static Zone[] Zones { get; } = (Zone[])Enum.GetValues(typeof(Zone));

//    public Zone GetFilter()
//    {
//        return UserSelection.SelectElement(Zones);
//    }
//}

//public class LineFilterStrategy : IFilterStrategy<Line>
//{
//    private static Line[] Lines { get; }

//    public Line GetFilter()
//    {
//        return UserSelection.SelectElement(Lines);
//    }
//}

//public class NameFilterStrategy : IFilterStrategy<string>
//{
//    public string GetFilter()
//    {
//        return UserInput.Read<string>(InputType.Station);
//    }
//}