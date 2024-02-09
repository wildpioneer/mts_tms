using OpenQA.Selenium;
using PageObjectSteps.Pages;
using PageObjectSteps.Pages.ProjectPages;

namespace PageObjectSteps.Steps;

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