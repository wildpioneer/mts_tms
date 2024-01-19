namespace NUnitTest;

[TestFixture]
public class FixtureExample : BaseTest
{
    [Test]
    public void Test1()
    {
        Console.WriteLine("Test1...");
        Assert.Pass();
    }

    // A test with a description property
    [Test(Description = "My really cool test")]
    public void Test2()
    {
        Console.WriteLine("Test2...");
        Assert.Pass();
    }

    // Alternate way to specify description as a separate attribute
    [Test, Description("My really really cool test")]
    public void Test3()
    {
        Console.WriteLine("Test3...");
        Assert.Pass();
    }

    // A simple async test
    [Test]
    public async Task AddAsync()
    {
        Console.WriteLine("AddAsync...");
        Assert.Pass();
    }


    // Async test with an expected result
    [Test(ExpectedResult = 4)]
    public async Task<int> Test5()
    {
        Console.WriteLine("Test5...");
        await AddAsync();
        return 2 + 2;
    }
}