using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

public class ScreenShotTest : BaseTest
{
    [Test]
    public void TestCreateLabel()
    {
        Driver.Navigate().GoToUrl("http://onliner.by");
        Assert.That(false);
    }
}