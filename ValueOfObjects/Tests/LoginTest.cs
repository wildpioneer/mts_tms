using ValueOfObjects.Helpers.Configuration;
using ValueOfObjects.Pages;

namespace ValueOfObjects.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        
        LoginPage loginPage = new LoginPage(Driver);
        DashboardPage dashboardPage = loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
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