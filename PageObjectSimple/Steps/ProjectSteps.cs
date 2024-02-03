using NUnitTest.Pages;
using OpenQA.Selenium;

namespace NUnitTest.Steps;

public class ProjectSteps : BaseStep
{
    public ProjectSteps(IWebDriver driver) : base(driver)
    {
    }

    public void NavigateToAddProjectPage()
    {
        new AddProjectPage(Driver, true);
    }
}