namespace XUnitTest;

public class UnitTest1 : IDisposable
{
    // Конструктор, выполняемый перед каждым тестом
    public UnitTest1()
    {
        // Инициализация ресурсов перед каждым тестом
    }

    // Метод, выполняемый перед каждым тестом
    [Fact]
    public void MyTestMethod()
    {
        // Arrange - подготовка данных

        // Act - действие, вызывающее тестируемый код

        // Assert - проверка результата
        Assert.Equal(4, 2 + 2);
    }

    // Метод, выполняемый после каждого теста
    [Fact]
    public void AnotherTestMethod()
    {
        // Arrange

        // Act

        // Assert
        Assert.True(true); // Простой пример утверждения
    }

    // Деструктор, выполняемый после всех тестов
    ~UnitTest1()
    {
        // Очистка ресурсов после выполнения всех тестов
    }

    // IDisposable implementation
    public void Dispose()
    {
        // Очистка ресурсов после каждого теста
    }

    // Тест, игнорируемый при выполнении
    [Fact(Skip = "Этот тест временно проигнорирован")]
    public void IgnoredTestMethod()
    {
        // Этот тест будет проигнорирован при выполнении
    }

    // Устанавливает максимальное время выполнения теста в миллисекундах
    [Fact(Timeout = 1000)] // Максимальное время выполнения теста - 1 секунда
    public void TimeoutTestMethod()
    {
        // Этот тест будет завершен, если займет более 1 секунды
        System.Threading.Thread.Sleep(2000);
    }
}