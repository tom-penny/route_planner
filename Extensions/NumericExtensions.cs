namespace RoutePlanner.Extensions;

public static class NumericExtensions
{
    public static string ToMinutes(this TimeSpan span)
    {
        return $"{span:m\\:ss}";
    }

    public static string ToUnits(this TimeSpan span) => span switch
    {
        { Hours: > 0 } => $"{span:h\\:mm\\:ss} hrs",
        { Minutes: > 0 } => $"{span:m\\:ss} mins",
        _ => $"{span:ss} secs",
    };
}