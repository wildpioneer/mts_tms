using Allure.Pages;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace Allure.Steps;

public class NavigationSteps : BaseStep
{
    public NavigationSteps(IWebDriver driver) : base(driver) { }
    
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver, true);
    }

    public DashboardPage NavigateToDashboardPage()
    {
        return new DashboardPage(Driver, true);
    }
    
    [AllureStep]
    public DashboardPage SuccessfulLogin(string username, string psw)
    {
        Login(username, psw);
        return DashboardPage;
    }

    public LoginPage IncorrectLogin(string username, string psw)
    {
        Login(username, psw);
        return LoginPage;
    }

    private void Login(string username, string psw)
    {
        LoginPage.EmailInput().SendKeys(username);
        LoginPage.PswInput().SendKeys(psw);
        LoginPage.LoginInButton().Click();
    }

}