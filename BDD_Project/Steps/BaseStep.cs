using BDD_Project.Pages;
using BDD_Project.Pages.ProjectPages;
using OpenQA.Selenium;

namespace BDD_Project.Steps;

public class BaseStep(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}