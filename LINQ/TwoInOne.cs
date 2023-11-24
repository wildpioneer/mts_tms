namespace LINQ;

public class TwoInOne
{
    public void run()
    {
        TestIntSet testSet = new TestIntSet();

        // Query Syntax + Method Syntax
        Console.WriteLine("Two in One");

        // Count
        int countResult =
            (from number in testSet
                where number % 2 == 0
                select number).Count();

        Console.WriteLine($"{countResult}");

        int maxResult =
            (from number in testSet
                where number % 2 == 0
                select number).Max();

        Console.WriteLine($"{maxResult}");
    }
}