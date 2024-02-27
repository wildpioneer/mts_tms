namespace ValueOfObjects.Tests;

[TestFixture]
public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        Logger.Info("SuccessfulLoginTest...");
        Assert.That(_navigationSteps.SuccessfulLogin(Admin).SidebarProjectsAddButton.Displayed);
    }
}