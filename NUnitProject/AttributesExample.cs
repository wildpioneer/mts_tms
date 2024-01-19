namespace NUnitTest;

[TestFixture(Category = "AttributesExample")]
public class AttributesExample
{
    [Test(Description = "Tests for Math Operations")]
    public void Test1()
    {
        
    }

    [Test, Category("Example")]
    public void Test2()
    {
        
    }

    [Test, Ignore("Ignoring these tests for now.")]
    public void Test3()
    {
        
    }

    [Test]
    public void Test4()
    {
        
    }
}