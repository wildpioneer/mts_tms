using OpenQA.Selenium;

namespace NUnitTest.Tests;

public class WaitsTest : BaseTest
{
    [Test]
    public void PresenceOfElementTest() {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

        IWebElement button = Driver.FindElement(By.TagName("button"));
        button.Click();
        Assert.IsTrue(button.Displayed);

        IWebElement loading = Driver.FindElement(By.Id("loading"));
        Assert.IsTrue(loading.Displayed);
        Assert.IsFalse(loading.Displayed);

        Assert.IsTrue(Driver.FindElement(By.Id("finish")).Displayed);
    }

    [Test]
    public void PresenceOfElementTest1() {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

        IWebElement button = WaitsHelper.WaitForVisibilityLocatedBy(By.TagName("button"));
        button.Click();
        Assert.IsTrue(WaitsHelper.WaitForElementInvisible(button));

        IWebElement loading = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("loading"));
        Assert.IsTrue(loading.Displayed);
        Assert.IsTrue(WaitsHelper.WaitForElementInvisible(loading));

        Assert.IsTrue(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("finish")).Displayed);
    }
}