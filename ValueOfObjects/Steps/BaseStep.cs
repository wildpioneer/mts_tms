using OpenQA.Selenium;
using ValueOfObjects.Pages;
using ValueOfObjects.Pages.ProjectPages;

namespace ValueOfObjects.Steps;

public class BaseStep(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    protected LoginPage? LoginPage;
    protected DashboardPage? DashboardPage;
    protected AddProjectPage? AddProjectPage;
}