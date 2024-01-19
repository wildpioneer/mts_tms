namespace NUnitTest;

[TestFixture]
public class TestCaseExample : BaseTest
{
    [TestCase(1, 2, ExpectedResult = 3)]
    [TestCase(-1, -2, ExpectedResult = -3)]
    public int Test(int x, int y)
    {
        return Calc.Sum(x, y);
    }
}