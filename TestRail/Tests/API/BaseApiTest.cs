using Allure.NUnit;
using TestRail.Clients;
using TestRail.Services;

namespace TestRail.Tests;

[Parallelizable(scope: ParallelScope.Fixtures)]
//[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
[AllureNUnit]
public class BaseApiTest : BaseSuite
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    protected ProjectService? ProjectService;
    private static RestClientExtended? _restClient;
    
    [OneTimeSetUp]
    public void SetUpApi()
    {
        _restClient = new RestClientExtended();
        ProjectService = new ProjectService(_restClient);
    }
}