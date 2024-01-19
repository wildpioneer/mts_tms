using AventStack.ExtentReports;

namespace NUnitTest;

public class AttributesExample
{
    private int x;
    
    [Test(Description = "Tests for Math Operations")]
    public void DemoTest()
    {
        Console.WriteLine($"{this}: DemoTest... {x++}");
    }

    [Test, Category("Example")]
    public void BigTest()
    {
        Console.WriteLine($"{this}: BigTest... {x++}");
    }

    [Test, Ignore("Ignoring these tests for now.")]
    public void AlphaTest()
    {
        Console.WriteLine($"{this}: AlphaTest... {x++}");
    }

    [Test, Order(1)]
    public void ZTest()
    {
        Console.WriteLine($"{this}: ZTest... {x++}");
    }

    [Test, Order(2)]
    public void XTest()
    {
        Console.WriteLine($"{this}: XTest... {x++}");
    }

    [Test, Order(2)]
    [Author("Jane Doe", "jane.doe@example.com")]
    [Author("Another Developer", "email@example.com")]
    public void AuthorTest()
    {
        Console.WriteLine($"{this}: XTest... {x++}");
    }
}