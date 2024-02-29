using BDD_Project.Models;
using BDD_Project.Pages;
using BDD_Project.Pages.ProjectPages;
using OpenQA.Selenium;

namespace BDD_Project.Steps;

public class NavigationSteps : BaseStep
{
    public NavigationSteps(IWebDriver driver) : base(driver) { }
    
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver, true);
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
        
        LoginPage.EmailInput.SendKeys(user.Email);
        LoginPage.PswInput.SendKeys(user.Password);
        LoginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}