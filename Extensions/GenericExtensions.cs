namespace RoutePlanner.Extensions;

public static class GenericExtensions
{
    public static T ThrowIfNull<T>(this T arg)
    {
        ArgumentNullException.ThrowIfNull(arg);
        return arg;
    }
}