using NUnitTest.Helpers.Configuration;
using OpenQA.Selenium;

namespace NUnitTest.Pages;

public abstract class BasePage
{
    protected IWebDriver Driver;

    public BasePage(IWebDriver driver, bool openPageByUrl)
    {
        Driver = driver;

        if (openPageByUrl)
        {
            OpenPageByUrl();
        }
    }

    public abstract bool IsPageOpened();
    protected abstract string GetEndpoint();

    private void OpenPageByUrl()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
    }
}