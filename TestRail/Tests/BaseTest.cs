using TestRail.Clients;
using TestRail.Services;

namespace TestRail.Tests;

public class BaseTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    protected ProjectService? ProjectService;
    
    [OneTimeSetUp]
    public void SetUpApi()
    {
        var restClient = new RestClientExtended();
        ProjectService = new ProjectService(restClient);
    }
}