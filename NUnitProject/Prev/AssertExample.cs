namespace NUnitTest;

[TestFixture]
public class AssertExample : BaseFixture
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
    
    
}