namespace RoutePlanner.Views;

public interface IViewer
{
    void Display();
}

public abstract class DisplayViewer : IViewer
{
    public static int DisplayWidth => 100;

    public abstract void Display();
}