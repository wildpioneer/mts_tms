namespace TestProject1;

[SetUpFixture]
public class CommonSetUpFixture
{
    [OneTimeSetUp]
    public void RunBeforeTestsInNamespace()
    {
        Console.WriteLine("RunBeforeTestsInNamespace");
    }

    [OneTimeTearDown]
    public void RunAfterTestsInNamespace()
    {
        // Очистка общих ресурсов
    }
}