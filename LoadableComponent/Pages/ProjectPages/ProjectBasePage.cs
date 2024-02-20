using OpenQA.Selenium;

namespace PageFactory.Pages.ProjectPages;

public abstract class ProjectBasePage(IWebDriver driver) : BasePage(driver)
{
    private static readonly By NameInputBy = By.Id("name");

    // Атомарные Методы
    public IWebElement NameInput => WaitsHelper.WaitForExists(NameInputBy);
}