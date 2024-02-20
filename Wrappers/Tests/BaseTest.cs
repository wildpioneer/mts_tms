using System.Text;
using Allure.Net.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using Wrappers.Core;
using Wrappers.Helpers;
using Wrappers.Helpers.Configuration;
using Wrappers.Steps;

namespace Wrappers.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
[AllureNUnit]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }

    protected NavigationSteps NavigationSteps;
    protected ProjectSteps ProjectSteps;

    [OneTimeSetUp]
    public static void GlobalSetup()
    {
        AllureLifecycle.Instance.CleanupResultDirectory();
    }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        
        // Инициализация Steps
        NavigationSteps = new NavigationSteps(Driver);
        ProjectSteps = new ProjectSteps(Driver);
    }
    
    [TearDown]
    public void TearDown()
    {
        // Проверка, был ли тест сброшен
        try
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                // Создание скриншота
                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                byte[] screenshotBytes = screenshot.AsByteArray;

                // Прикрепление скриншота к отчету Wrappers
                // Вариант 1
                AllureLifecycle.Instance.AddAttachment("Screenshot", "image/png", screenshotBytes);
            
                // Вариант 2
                AllureApi.AddAttachment(
                    "data.txt",
                    "text/plain",
                    Encoding.UTF8.GetBytes("This is the file content.")
                );
                AllureApi.AddAttachment(
                    "Screenshot",
                    "image/png",
                    screenshotBytes
                );
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        Driver.Quit();
    }
}