using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

[AllureParentSuite("Web interface")]
[AllureSuite("Essential features")]
public class SuiteAllureTest : BaseTest
{
    [Test]
    [AllureSubSuite("Labels")]
    public void TestCreateLabel()
    {
        Assert.That(true);
    }

    [Test]
    [AllureStory("Labels")]
    public void TestCreateLabelByApi()
    {
        AllureApi.AddParentSuite("Web interface");
        AllureApi.AddSuite("Essential features");
        AllureApi.AddSubSuite("Labels");
        
        Assert.That(true);
    }
}