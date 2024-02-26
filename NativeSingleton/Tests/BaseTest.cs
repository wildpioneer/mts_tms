using OpenQA.Selenium;

namespace NativeSingleton.Tests;

public class BaseTest
{
    [OneTimeSetUp]
    public void Setup()
    {
        WebDriverSingleton.GetInstance().GetDriver();
        
        WebDriverSingleton.GetInstance().GetDriver().Navigate().GoToUrl("http://onliner.by");
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        WebDriverSingleton.GetInstance().CloseDriver();
    }
}