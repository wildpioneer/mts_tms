using OpenQA.Selenium;
using PageFactory.Core;
using PageFactory.Helpers.Configuration;

namespace PageFactory.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}