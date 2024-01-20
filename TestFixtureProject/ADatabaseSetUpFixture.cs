namespace TestProject1;

[SetUpFixture]
public class ADatabaseSetUpFixture
{
    [OneTimeSetUp]
    public void InitializeDatabase()
    {
        Console.WriteLine("InitializeDatabase");
    }

    [OneTimeTearDown]
    public void CleanUpDatabase()
    {
        // Очистка базы данных после тестов
    }
}