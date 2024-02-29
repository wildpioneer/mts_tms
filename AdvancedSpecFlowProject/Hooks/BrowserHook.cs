using BDD_Project.Core;
using BDD_Project.Helpers.Configuration;
using BDD_Project.Steps;
using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace AdvancedSpecFlowProject.Hooks;

[Binding]
public class BrowserHook
{
    private readonly Browser _browser;

    public BrowserHook(Browser browser)
    {
        _browser = browser;
    }

    ///<summary>
    ///  Start Browser 
    /// </summary>
    [BeforeScenario("GUI")]
    public void BeforeScenario()
    {
        Console.WriteLine("Start Browser");
        var navigationStep = new NavigationSteps(_browser.Driver);
        try
        {
            _browser.Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            navigationStep.NavigateToLoginPage();
        }
        catch (Exception e)
        {
            Assert.Fail("Could not load Login Page");
        }
    }

    [AfterScenario("GUI")]
    public void AfterScenario()
    {
        _browser.Driver.Quit();
    }
}