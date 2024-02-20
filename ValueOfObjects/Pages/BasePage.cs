using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ValueOfObjects.Helpers;
using ValueOfObjects.Helpers.Configuration;

namespace ValueOfObjects.Pages;

public abstract class BasePage : LoadableComponent<BasePage>
{
    protected IWebDriver Driver { get; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected BasePage(IWebDriver driver)
    {
        Driver = driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
    }

    protected abstract string GetEndpoint();

    protected override void ExecuteLoad()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
    }
}