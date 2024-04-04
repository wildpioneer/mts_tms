using Allure.Net.Commons;

namespace TestRail.Tests;

public class BaseSuite
{
    //[OneTimeSetUp]
    public static void GlobalSetup()
    {
        AllureLifecycle.Instance.CleanupResultDirectory();
    }
}