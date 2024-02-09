using PageObjectSimple.Helpers.Configuration;
using PageObjectSimple.Pages;

namespace PageObjectSimple.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        // Простой вид
        LoginPage loginPage = new LoginPage(Driver);
        DashboardPage dashboardPage = loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        Assert.That(dashboardPage.IsPageOpened());
    }
    
    [Test]
    public void InvalidUsernameLoginTest()
    {
        // Вид в стилистике Builder
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("ssdd", "")
                .ErrorLabel.Text.Trim(), 
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
}