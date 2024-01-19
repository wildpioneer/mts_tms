namespace NUnitTest;

public class BaseTest
{
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("SetUp...");
    }

    [TearDown]
    public void TearDown()
    {
        Console.WriteLine("TearDown...");
    }
}