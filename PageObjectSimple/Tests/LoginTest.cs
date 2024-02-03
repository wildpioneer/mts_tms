using NUnitTest.Helpers.Configuration;
using NUnitTest.Steps;

namespace NUnitTest.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessLoginTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.IsTrue(NavigationSteps.DashboardPage.IsPageOpened());
    }
}