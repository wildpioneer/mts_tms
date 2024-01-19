namespace NUnitTest;

public class TestContextExample
{
    [Test]
    public void Test()
    {
        Console.WriteLine($"{this}: {TestContext.CurrentContext.Test.MethodName}...");
    }

}