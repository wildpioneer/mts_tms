using NativeSingleton.Core;
using NativeSingleton.Helpers.Configuration;
using NativeSingleton.Steps;

namespace NativeSingleton.Tests;

[SetUpFixture]
public class MySetUpFixture
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        BrowserSingleton.GetInstance().GetDriver().Navigate().GoToUrl(Configurator.AppSettings.URL);
        new NavigationSteps().SuccessfulLoginByAdmin();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        BrowserSingleton.GetInstance().CloseDriver();
    }
}