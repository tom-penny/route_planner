using RoutePlanner.Controllers;

namespace RoutePlanner;

public class Application
{
    private readonly IController _tenantController;

    public Application(IController tenantController)
    {
        _tenantController = tenantController;
    }

    public void Run()
    {
        _tenantController.Initiate();
        Exit();
    }

    private void Exit()
    {
        Environment.Exit(0);
    }
}