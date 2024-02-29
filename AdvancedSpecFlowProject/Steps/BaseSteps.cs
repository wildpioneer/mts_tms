using BDD_Project.Core;
using BDD_Project.Steps;
using OpenQA.Selenium;

namespace AdvancedSpecFlowProject.Steps;

public class BaseSteps
{
    protected IWebDriver Driver;
    protected NavigationSteps _navigationSteps;

    public BaseSteps(Browser browser)
    {
        Driver = browser.Driver;
        _navigationSteps = new NavigationSteps(Driver);
    }
}