namespace NativeSingleton.Tests;

[TestFixture]
public class LoginTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        WebDriverSingleton.GetInstance().GetDriver().Navigate().GoToUrl("http://google.com");
    }
}