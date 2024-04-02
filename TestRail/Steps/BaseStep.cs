using OpenQA.Selenium;
using TestRail.Pages;
using TestRail.Pages.ProjectPages;

namespace TestRail.Steps;

public class BaseStep(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}