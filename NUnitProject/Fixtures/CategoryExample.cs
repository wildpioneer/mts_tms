namespace NUnitTest.Fixtures;

// Категории тестов можно указывать как для всего класса, так и для отдельных методов.
[TestFixture, Category("UnitTests")]
public class CategoryExample : BaseTest
{
    [Test, Category("MathOperations")]
    public void AdditionTest()
    {
        // Тестовый код
    }

    [Test, Category("MathOperations")]
    public void SubtractionTest()
    {
        // Тестовый код
    }

    [Test, Category("StringOperations")]
    public void StringConcatenationTest()
    {
        // Тестовый код
    }
}