using RoutePlanner.Helpers;

namespace RoutePlanner.Controllers;

public class TenantController : Controller
{
    private readonly IController _customerController;
    private readonly IController _engineerController;

    public TenantController(IController customerController, IController engineerController)
    {
        _customerController = customerController;
        _engineerController = engineerController;
        Options = CreateOptions();
    }

    protected override ControllerOption[] CreateOptions() => new[]
    {
        new ControllerOption("Customer Menu", CustomerMenu),
        new ControllerOption("Engineer Menu", EngineerMenu),
        new ControllerOption("Exit", Return)
    };

    private bool CustomerMenu()
    {
        _customerController.Initiate();
        return false;
    }
    private bool EngineerMenu()
    {
        _engineerController.Initiate();
        return false;
    }
}