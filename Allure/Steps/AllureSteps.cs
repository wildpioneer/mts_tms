using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace Allure.Steps;

public class AllureSteps : BaseStep
{
    public AllureSteps(IWebDriver driver) : base(driver)
    {
    }

    [AllureStep("Test {url}")]
    public void TestDomain([Name("Webpage URL")] string url)
    {
        // Добавление дополнительной информации
        AllureLifecycle.Instance.UpdateStep(stepResult =>
            stepResult.parameters.Add(
                new Parameter
                {
                    name = "Started at", value = DateTime.Now.ToString()
                }
            )
        );
        
        OpenBrowser();
        GoToWebpage(url);
        CloseBrowser();
    }

    [AllureStep("Open web browser")]
    private void OpenBrowser()
    {
        Assert.That(true);
    }

    [AllureStep("Visit {url}")]
    private void GoToWebpage([Skip] string url)
    {
        Assert.That(true);
    }

    [AllureStep("Close web browser")]
    private void CloseBrowser()
    {
        Assert.That(true);
    }
}
