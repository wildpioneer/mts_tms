namespace NUnitTest;

public class AssertExample
{
    [Test]
    public void PassTest()
    {
        Console.WriteLine("Pass test...");
        Assert.Pass();
    }

    [Test]
    public void FailTest()
    {
        Console.WriteLine("Fail test...");
        //Assert.Fail();
    }

    [Test]
    public void AreEqualTest()
    {
        Console.WriteLine("AreEqual test...");
        Assert.AreEqual(Calc.Sum(1, 2), 3);
        Assert.That(Calc.Sum(1, 2), Is.EqualTo(3));
    }
    
    // Test with an expected result
    [Test(ExpectedResult = 4)]
    public int ExpectedResultTest()
    {
        Console.WriteLine("ExpectedResultTest...");
        return 2 + 2;
    }
}