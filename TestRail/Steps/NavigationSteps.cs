using OpenQA.Selenium;
using TestRail.Models;
using TestRail.Pages;
using TestRail.Pages.ProjectPages;

namespace TestRail.Steps;

public class NavigationSteps : BaseStep
{
    public NavigationSteps(IWebDriver driver) : base(driver) { }
    
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver);
    }

    public DashboardPage NavigateToDashboardPage()
    {
        return new DashboardPage(Driver);
    }
    
    public AddProjectPage NavigateToAddProjectPage()
    {
        return new AddProjectPage(Driver);
    }
    
    public DashboardPage SuccessfulLogin(User user)
    {
        return Login<DashboardPage>(user);
    }

    public LoginPage IncorrectLogin(User user)
    {
        return Login<LoginPage>(user);
    }
    
    public T Login<T>(User user) where T : BasePage
    {
        LoginPage = new LoginPage(Driver);
        
        LoginPage.EmailInput.SendKeys(user.Username);
        LoginPage.PswInput.SendKeys(user.Password);
        LoginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}