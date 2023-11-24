namespace LINQ;

public class Except
{
    private TestIntSet _testIntSet = new();
    List<int> blackList = new() { 3, 6, 8 , -1, 12};

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
        
        // Разность последовательностей
        // Начать с метода
        var queryResult =
            from number in _testIntSet
            where !blackList.Contains(number) 
            select number;

        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }
    }
    
    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        
        // Разность последовательностей
        var queryResult = _testIntSet.Except(blackList);

        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }

    }
}