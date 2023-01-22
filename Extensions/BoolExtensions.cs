namespace RoutePlanner.Extensions;

public static class BoolExtensions
{
    public static void AwaitKey(this bool await)
    {
        if (!await) return;
        Console.WriteLine("\nPress any key to continue.");
        Console.ReadKey();
    }
}