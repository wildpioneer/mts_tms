namespace NativeSingleton.Tests;

[SetUpFixture]
public class MySetUpFixture
{
    //[OneTimeSetUp]
    public void OneTimeSetUp()
    {
        WebDriverSingleton.GetInstance().GetDriver().Navigate().GoToUrl("http://onliner.by");
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        WebDriverSingleton.GetInstance().CloseDriver();
    }
}