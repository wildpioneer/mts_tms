using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

public class AllureTest : BaseTest
{
    [Test(Description = "Some detailed test description")]
    public void TestDescription()
    {
        Assert.That(true);
    }
    
    [Test]
    [AllureSeverity(SeverityLevel.critical)]
    public void TestSeverity()
    {
        Assert.That(true);
    }

    [Test]
    [AllureStory("Test Story")]
    public void TestStory()
    {
        Assert.That(true);
    }

    [Test]
    [AllureIssue("PR-123")]
    [AllureIssue("PR-456")]
    public void TestIssue()
    {
        Assert.That(true);
    }

    [Test]
    [AllureTms("TMS-123")]
    [AllureTms("TMS-456")]
    public void TestTMS()
    {
        Assert.That(true);
    }

    [Test]
    [AllureLink("Website", "https://dev.example.com/")]
    public void testLink()
    {
        Assert.That(true);
    }
    
    [Test]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureOwner("John Doe")]
    [AllureLink("Website", "https://dev.example.com/")]
    [AllureIssue("UI-123")]
    [AllureTms("TMS-456")]
    public void TestCreateLabel()
    {
        Assert.That(true);
    }
    
    [Test]
    public void TestCreateLabelByApi()
    {
        AllureApi.AddEpic("Web interface");
        AllureApi.AddFeature("Essential features");
        AllureApi.AddStory("Labels");
        
        Assert.That(true);
    }
}