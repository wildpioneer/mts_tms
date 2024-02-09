using NUnitTest.Helpers.Configuration;
using NUnitTest.Pages;
using NUnitTest.Steps;

namespace NUnitTest.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        // Actions = Действия
        Assert.That(new LoginPage(Driver)
            .SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
            .IsPageOpened());
        
        // Проверка
        Assert.That(
            UserSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .TitleLabel.Text.Trim(), 
            Is.EqualTo("All Projects"));
    }
    
    [Test]
    public void InvalidUsernameLoginTest()
    {
        // Проверка
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("ssdd", "")
                .ErrorLabel.Text.Trim(), 
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
}