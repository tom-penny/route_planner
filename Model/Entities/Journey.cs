namespace RoutePlanner.Model.Entities
{
    public class Journey
    {
        public Station Origin { get; }
        public Station Destination { get; }
        public Stack<ITraversal> Route { get; }

        public TimeSpan JourneyTime => GetJourneyTime();

        public Journey(Station origin, Station destination, Stack<ITraversal> route)
        {
            Origin = origin;
            Destination = destination;
            Route = route;
        }

        private TimeSpan GetJourneyTime()
        {
            var durations = Route.Select(l => l.Duration);
            return durations.Aggregate(TimeSpan.Zero, (current, duration) => current + duration);
        }
    }
}
