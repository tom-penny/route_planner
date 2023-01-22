namespace RoutePlanner.Extensions;

public static class LineExtensions
{
    public static TimeSpan AverageDelay(this TubeLine line)
    {
        return TimeSpan.FromMinutes(GetLineAverage(line) * 2 * GetTimeCoefficient());
    }
    public static string AverageCrowding() => GetTimeCoefficient() switch
    {
        < 0.33 => "quiet",
        < 0.66 => "busy",
        _ => "very busy"
    };
    public static ConsoleColor Color(this TubeLine line) => line switch
    {
        TubeLine.Bakerloo => ConsoleColor.DarkYellow,
        TubeLine.Central => ConsoleColor.Red,
        TubeLine.Circle => ConsoleColor.Yellow,
        TubeLine.District => ConsoleColor.DarkGreen,
        TubeLine.Jubilee => ConsoleColor.DarkGray,
        TubeLine.Northern => ConsoleColor.Black,
        TubeLine.Overground => ConsoleColor.Cyan,
        TubeLine.Piccadilly => ConsoleColor.DarkBlue,
        TubeLine.Victoria => ConsoleColor.Blue
    };

    private static double GetLineAverage(TubeLine line) => line switch
    {
        TubeLine.Bakerloo => 3.15,
        TubeLine.Central => 4.25,
        TubeLine.Circle => 4.9,
        TubeLine.District => 5.29,
        TubeLine.Jubilee => 2.47,
        TubeLine.Northern => 1.77,
        TubeLine.Piccadilly => 4.01,
        TubeLine.Victoria => 3.08,
        TubeLine.Overground => 3.62,
        _ => throw new NotSupportedException()
    };
    private static double GetTimeCoefficient() => TimeOnly.FromDateTime(DateTime.UtcNow).Hour switch
    {
        05 => 0.05d,
        06 => 0.26d,
        07 => 0.64d,
        08 => 0.93d,
        09 => 0.53d,
        10 => 0.33d,
        11 => 0.30d,
        12 => 0.33d,
        13 => 0.35d,
        14 => 0.36d,
        15 => 0.44d,
        16 => 0.62d,
        17 => 0.92d,
        18 => 0.78d,
        19 => 0.44d,
        20 => 0.30d,
        21 => 0.24d,
        22 => 0.23d,
        23 => 0.17d,
        00 => 0.04d,
        _ => double.PositiveInfinity
    };
}