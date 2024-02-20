using OpenQA.Selenium;
using ValueOfObjects.Pages;
using ValueOfObjects.Pages.ProjectPages;

namespace ValueOfObjects.Steps;

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
    
    public DashboardPage SuccessfulLogin(string username, string psw)
    {
        return Login<DashboardPage>(username, psw);
    }

    public LoginPage IncorrectLogin(string username, string psw)
    {
        return Login<LoginPage>(username, psw);
    }
    
    public T Login<T>(string username, string psw) where T : BasePage
    {
        LoginPage = new LoginPage(Driver);
        
        LoginPage.EmailInput.SendKeys(username);
        LoginPage.PswInput.SendKeys(psw);
        LoginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver);
    }
}