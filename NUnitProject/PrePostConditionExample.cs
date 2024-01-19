namespace NUnitTest;

public class PrePostConditionExample
{
    #region One Time Precondition Section
    /// <summary>
    /// Initializes Global test objects
    /// </summary>
    /// 
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Console.WriteLine($"{this}: OneTimeSetUp...");
    }
    #endregion
    
    [SetUp]
    public void Setup()
    {
        Console.WriteLine($"{this}: SetUp...");
    }

    [Test]
    public void Test()
    {
        Console.WriteLine($"{this}: Test...");
    }
    
    [TearDown]
    public void TearDown()
    {
        Console.WriteLine($"{this}: TearDown...");
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Console.WriteLine($"{this}: OneTimeTearDown...");
    }
}