using BuilderPattern.Pages;
using BuilderPattern.Pages.ProjectPages;
using OpenQA.Selenium;

namespace BuilderPattern.Steps;

public class BaseStep(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}