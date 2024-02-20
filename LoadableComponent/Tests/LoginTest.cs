using PageFactory.Helpers.Configuration;
using PageFactory.Pages;

namespace PageFactory.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        
        DashboardPage dashboardPage = loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        Driver.Navigate().GoToUrl("https://aqa2503.testrail.io/index.php?/mysettings");
        
        dashboardPage.Load();  // Принудительная загрузка
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