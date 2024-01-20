namespace MSTestProject;

[TestClass]
public class UnitTest1
{
    // Тестовый метод с атрибутом [TestMethod]
    [TestMethod]
    public void MyTestMethod()
    {
        // Arrange - подготовка данных

        // Act - действие, вызывающее тестируемый код

        // Assert - проверка результата
        Assert.AreEqual(4, 2 + 2, "Ожидается, что 2 + 2 равно 4.");
    }

    // Тестовый метод, который будет выполняться после каждого теста с атрибутом [TestCleanup]
    [TestCleanup]
    public void TestCleanup()
    {
        // Код для очистки ресурсов после завершения каждого теста
    }

    // Тестовый метод, который будет выполняться перед каждым тестом с атрибутом [TestInitialize]
    [TestInitialize]
    public void TestInitialize()
    {
        // Код для инициализации ресурсов перед каждым тестом
    }

    // Метод, который будет выполняться единожды перед началом выполнения всех тестов в классе с атрибутом [ClassInitialize]
    [ClassInitialize]
    public static void ClassInitialize(TestContext context)
    {
        // Код для инициализации ресурсов перед выполнением всех тестов в классе
    }

    // Метод, который будет выполняться единожды после завершения выполнения всех тестов в классе с атрибутом [ClassCleanup]
    [ClassCleanup]
    public static void ClassCleanup()
    {
        // Код для очистки ресурсов после выполнения всех тестов в классе
    }

    // Тестовый метод с атрибутом [Ignore], который будет проигнорирован при выполнении
    [TestMethod]
    [Ignore("Этот тест временно проигнорирован")]
    public void IgnoredTestMethod()
    {
        // Этот тест будет проигнорирован при выполнении
    }

    // Тестовый метод с атрибутом [Timeout], указывающим максимальное время выполнения теста в миллисекундах
    [TestMethod]
    [Timeout(1000)] // Максимальное время выполнения теста - 1 секунда
    public void TimeoutTestMethod()
    {
        // Этот тест будет завершен, если займет более 1 секунды
        System.Threading.Thread.Sleep(2000);
    }
}