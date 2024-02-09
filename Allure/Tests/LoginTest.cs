using Allure.Helpers.Configuration;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

[TestFixture(Author = "Alex", Description = "Login Tests")]
public class LoginTest : BaseTest
{
    [Test]
    [AllureTag("NUnit", "Debug")]
    [AllureIssue("GitHub#1", "https://github.com/allure-framework/allure-csharp")]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureFeature("Core")]
    [AllureId(123)]
    public void SuccessLoginTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(NavigationSteps.DashboardPage.IsPageOpened());
    }
}