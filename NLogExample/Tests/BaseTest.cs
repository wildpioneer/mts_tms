using NLog;
using OpenQA.Selenium;
using ValueOfObjects.Core;
using ValueOfObjects.Helpers.Configuration;
using ValueOfObjects.Models;
using ValueOfObjects.Steps;

namespace ValueOfObjects.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    
    protected IWebDriver Driver { get; private set; }

    protected NavigationSteps _navigationSteps;
    protected ProjectSteps _projectSteps;

    protected User Admin { get; private set; }

    [SetUp]
    public void Setup()
    {
        Logger.Info("Method setup started...");
        
        Driver = new Browser().Driver;
        Logger.Debug(Driver);

        _navigationSteps = new NavigationSteps(Driver);
        _projectSteps = new ProjectSteps(Driver);

        Admin = new User
        {
            Email = Configurator.AppSettings.Username,
            Password = Configurator.AppSettings.Password
        };
        Logger.Info(Admin);
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}