namespace TestProject1;

public class BaseTest
{
    [OneTimeSetUp, Category("Smoke")]
    public void OnetimeSetup()
    {
        Console.WriteLine("OneTimeSetUp...");
    }

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
    
    [OneTimeTearDown]
    public void OnetimeTeardown()
    {
        Console.WriteLine("OneTimeTearDown...");
    }
}