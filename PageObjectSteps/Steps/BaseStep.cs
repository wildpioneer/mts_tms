using OpenQA.Selenium;
using PageObjectSteps.Pages;
using PageObjectSteps.Pages.ProjectPages;

namespace PageObjectSteps.Steps;

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