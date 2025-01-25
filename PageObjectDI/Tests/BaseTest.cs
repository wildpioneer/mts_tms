using Autofac;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectDI.Core;
using PageObjectDI.Helpers.Configuration;
using PageObjectDI.Pages;

namespace PageObjectDI.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IContainer? Container { get; private set; }
    
    //[OneTimeSetUp]
    [SetUp]
    public void Setup()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<Browser>().SingleInstance();
        builder.Register(c => c.Resolve<Browser>().Driver).As<IWebDriver>().InstancePerDependency();
        builder.RegisterType<LoginPage>();
        builder.RegisterType<DashboardPage>();
        Container = builder.Build();
        
        Container.Resolve<IWebDriver>().Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    //[OneTimeTearDown]
    [TearDown]
    public void TearDown()
    {
        Container?.Resolve<IWebDriver>().Quit();
        Container?.Dispose();
    }
}