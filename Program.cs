namespace RoutePlanner;

public class Program
{
    public static void Main(string[] args)
    {
        Connections.AddConnections();
        var app = Container.CreateApplication();
        app.Run();
    }
}