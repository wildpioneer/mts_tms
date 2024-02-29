using BDD_Project.Core;
using BDD_Project.Models;

namespace AdvancedSpecFlowProject.Steps;

[Binding]
public class LoginSteps : BaseSteps
{
    public LoginSteps(Browser browser) : base(browser)
    {
    }

    [Given(@"new browser is opened")]
    public void NewBrowserIsOpened()
    {
    }

    [Given(@"a login page is opened")]
    public void ALoginPageIsOpened()
    {
        _navigationSteps.NavigateToLoginPage();
    }

    [Given(@"the user ""(.*)"" with password ""(.*)"" logged in")]
    public void TheUserWithPasswordLoggedIn(string username, string password)
    {
        _navigationSteps.SuccessfulLogin(new User
        {
            Email = username,
            Password = password
        });
    }
}