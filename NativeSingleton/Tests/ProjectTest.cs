namespace NativeSingleton.Tests;

[TestFixture]
public class ProjectTest
{
    [Test]
    public void SuccessfulAddProjectTest()
    {
        WebDriverSingleton.GetInstance().GetDriver().Navigate().GoToUrl("http://onliner.by");
    }
}