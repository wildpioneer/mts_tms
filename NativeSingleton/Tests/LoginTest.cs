using NativeSingleton.Pages;

namespace NativeSingleton.Tests;

[TestFixture]
public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        Assert.That(new DashboardPage().SidebarProjectsAddButton.Displayed);
    }
}