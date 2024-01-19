namespace NUnitTest;

// Старый вариант
[SetUpFixture]
public class BaseFixture
{
    [OneTimeSetUp, Category("Main")]
    public void OnetimeSetup()
    {
        Console.WriteLine("OneTimeSetUp...");
    }

    [OneTimeSetUp, Category("AttributesExample")]
    public void OnetimeSetup1()
    {
        Console.WriteLine("AttributesExample OneTimeSetUp...");
    }
    
    [OneTimeTearDown]
    public void OnetimeTeardown()
    {
        Console.WriteLine("OneTimeTearDown...");
    }
}