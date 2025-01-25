using Autofac;
using PageObjectDI.Helpers.Configuration;
using PageObjectDI.Pages;

namespace PageObjectDI.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        var loginPage = Container!.Resolve<LoginPage>();
        var dashboardPage = loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        Assert.That(dashboardPage.IsPageOpened());
    }
    
    [Test]
    public void InvalidUsernameLoginTest()
    {
        // Вид в стилистике Builder
        Assert.That(
            Container!.Resolve<LoginPage>()
                .IncorrectLogin("ssdd@asd.ru", Configurator.AppSettings.Username)
                .ErrorLabel.Text.Trim(), 
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }

    [Test]
    public void InvalidPasswordLoginTest()
    {
        // Вид в стилистике Builder
        Assert.That(
            Container!.Resolve<LoginPage>()
                .IncorrectLogin(Configurator.AppSettings.Username, "asdasd")
                .ErrorLabel.Text.Trim(), 
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
}