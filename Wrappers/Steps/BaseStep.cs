using OpenQA.Selenium;
using Wrappers.Pages;
using Wrappers.Pages.ProjectPages;

namespace Wrappers.Steps;

public class BaseStep
{
    protected IWebDriver Driver;

    public LoginPage LoginPage => new LoginPage(Driver);
    public DashboardPage DashboardPage => new DashboardPage(Driver);
    public AddProjectPage AddProjectPage => new AddProjectPage(Driver);

    public BaseStep(IWebDriver driver)
    {
        Driver = driver;
    }
}