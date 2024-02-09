using Allure.Helpers.Configuration;

namespace Allure.Tests;

public class ProjectsTest : BaseTest
{
    [Test]
    public void CreateProjectTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        ProjectSteps.NavigateToAddProjectPage();
    }
}