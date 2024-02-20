using OpenQA.Selenium;

namespace PageFactory.Pages.ProjectPages;

public abstract class ProjectBasePage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private static readonly By NameInputBy = By.Id("name");

    // Атомарные Методы
    public IWebElement NameInput => WaitsHelper.WaitForExists(NameInputBy);
}