namespace RoutePlanner.Model.Entities;

public interface ITraversable { }

public interface ITraversal
{
    public ITraversable Origin { get; }
    public ITraversable Destination { get; }
    public ITraversable Via { get; }
    public TimeSpan Duration { get; }
}

public abstract class Traversal : ITraversal
{
    public abstract ITraversable Origin { get; }
    public abstract ITraversable Destination { get; }
    public abstract ITraversable Via { get; }
    public abstract TimeSpan Duration { get; }
}