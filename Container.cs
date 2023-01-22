using RoutePlanner.Controllers;
using RoutePlanner.Model;
using RoutePlanner.Model.Algorithms;
using RoutePlanner.Model.DataAccess;
using RoutePlanner.Model.Entities;
using RoutePlanner.Views;

namespace RoutePlanner;

public static class Container
{
    public static Application CreateApplication() => new(CreateTenantController());

    public static IController CreateTenantController() => new TenantController(CreateCustomerController(), CreateEngineerController());

    public static IController CreateCustomerController() => new CustomerController(CreateStationViewer(), CreateJourneyViewer());
    public static IViewer CreateStationViewer() => new StationViewer(CreateStationSelector(), CreateStatusMonitor());
    public static IViewer CreateJourneyViewer() => new JourneyViewer(CreateStationSelector(), CreateJourneyPlanner());

    public static IController CreateEngineerController() => new EngineerController(CreateNetworkMonitor(), CreateConnectionManager(), CreateStationManager());
    public static IController CreateNetworkMonitor() => new NetworkMonitor(CreateClosureViewer(), CreateDelayViewer());
    public static IController CreateConnectionManager() => new ConnectionManager(CreateConnectionSelector());
    public static IController CreateStationManager() => new StationManager(CreateStationSelector());

    public static IViewer CreateDelayViewer() => new DelayViewer(CreateConnections());
    public static IViewer CreateClosureViewer() => new ClosureViewer(CreateConnections());

    public static ConnectionRepository CreateConnections() => new();
    public static ISelector<Station> CreateStationSelector() => new StationSelector(CreateStationFilter());
    public static ISelector<Connection> CreateConnectionSelector() => new ConnectionSelector(CreateStationSelector());

    public static StationFilter CreateStationFilter() => new(CreateLineStrategy(), CreateNameStrategy(), CreateZoneStrategy());
    public static IStationFilterStrategy CreateZoneStrategy() => new ZoneFilterStrategy();
    public static IStationFilterStrategy CreateLineStrategy() => new LineFilterStrategy();
    public static IStationFilterStrategy CreateNameStrategy() => new NameFilterStrategy();

    public static JourneyPlanner CreateJourneyPlanner() => new(CreatePathFinder());
    public static IRouteFinder CreatePathFinder() => new RouteFinder();

    public static StatusMonitor CreateStatusMonitor() => new(CreateConnections());
}