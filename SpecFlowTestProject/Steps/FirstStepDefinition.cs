using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowTestProject.Steps;

[Binding]
public class FirstStepDefinition
{
    private IWebDriver? _driver;

    [Given(@"открыт браузер")]
    public void OpenBrowser()
    {
        Console.WriteLine("Browser is opened...");
        _driver = new ChromeDriver();
    }

    [When(@"страница логина открыта")]
    [Given(@"страница логина открыта")]
    public void OpenLoginPage()
    {
        Console.WriteLine("Browser is opened...");
        _driver.Navigate().GoToUrl("http://onliner.by");
    }

    [Then(@"username field is displayed")]
    public void IsUsernameFieldDisplayed()
    {
        Assert.That(true);
        //_driver.Quit();
    }

    [Given(@"user logged in")]
    public void UserLoggedIn()
    {
        Console.WriteLine("Browser is opened...");
    }

    [When(@"user ""(.*)"" with password ""(.*)"" logged in")]
    public void UserWithPasswordLoggedIn(string username, string password)
    {
        Console.WriteLine($"User {username} logged in with psw {password}");
    }

    [Then(@"add project button is displayed")]
    public void ThenAddProjectButtonIsDisplayed()
    {
        Console.WriteLine("Button is displayed...");
    }

    [Then(@"username is ""(.*)""")]
    public void ThenUsernameIs(string username)
    {
        Console.WriteLine($"User has {username}");
    }

    [Then(@"project id is (.*)")]
    public void IsProjectIdEqualsTo(int id)
    {
        Assert.That(id, Is.EqualTo(23));
    }

    [AfterScenario]
    public void CloseDriver()
    {
        _driver?.Quit();
    }

    [Given(@"a blog post named ""(.*)"" with Markdown body")]
    public void GivenABlogPostNamedWithMarkdownBody(string random, string multilineText)
    {
        ScenarioContext.StepIsPending();
    }
}