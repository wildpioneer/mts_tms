namespace LINQ;

public class Union
{
    private TestIntSet _testIntSet = new();
    List<int> blackList = new() { 3, 6, 8, -1, 12 };

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        // Объединение последовательностей
        // Начать с метода
        var queryResult =
            (
                from number in _testIntSet
                select number)
            .Union(
                from number in blackList
                select number);

        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // Объединение последовательностей
        var queryResult = _testIntSet.Union(blackList);

        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }
    }
}