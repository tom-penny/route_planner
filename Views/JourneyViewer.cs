using RoutePlanner.Extensions;
using RoutePlanner.Helpers;
using RoutePlanner.Model.Algorithms;
using RoutePlanner.Model.DataAccess;
using RoutePlanner.Model.Entities;
using System.Text;

namespace RoutePlanner.Views;

public class JourneyViewer : DisplayViewer
{
    private readonly ISelector<Station> _stationSelector;
    private readonly JourneyPlanner _journeyPlanner;

    public JourneyViewer(ISelector<Station> stationSelector, JourneyPlanner journeyPlanner)
    {
        _stationSelector = stationSelector;
        _journeyPlanner = journeyPlanner;
    }

    public override void Display()
    {
        var origin = _stationSelector.Select();
        var destination = _stationSelector.Select();
        DisplayJourney(origin, destination);
        true.AwaitKey();
    }

    private void DisplayJourney(Station origin, Station destination)
    {
        Console.Clear();
        DisplayElements.Header(DisplayWidth, "Journey Planner", ConsoleColor.White);
        DisplayElements.SubHeader(DisplayWidth, $"Route: {origin} to {destination}", ConsoleColor.White);
        switch (_journeyPlanner.GetJourney(origin, destination))
        {
            case { } journey: PrintJourney(journey); break;
            default: Console.WriteLine($"No direct routes available between {origin} and {destination}."); break;
        }
    }
    private void PrintJourney(Journey journey)
    {
        var arr = journey.Route.ToArray();
        for (var i = 0; i < arr.Length; i++)
        {
            var leg = arr[i];
            Console.Write($"({i + 1}) ");
            if (leg is Interchange change)
            {
                Console.Write($"{"Change:",-10}{change.Via}\n    ");
            }
            if (i == 0 || i == arr.Length - 1)
            {
                Console.Write($"{(i == 0 ? "Start:" : "End"),-10}{leg}\n\n");
            }
            else Console.Write($"{"",-10}{leg}\n\n");
        }
        var time = journey.JourneyTime;
        Console.WriteLine($"Total Journey Time: {(time.Hours > 0 ? $"{time}hrs" : $"{time.ToMinutes()}mins")}");
    }
}