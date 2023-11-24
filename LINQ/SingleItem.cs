namespace LINQ;

public class SingleItem
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        // First
        var queryResult =
            from num in _testIntSet
            where (num == 4 || num == 6)
            select (num);
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // First
        var queryResult = _testIntSet.Where(num => num == 4 || num == 6).First();
        var queryResult1 = _testIntSet.First(num => num == 4 || num == 6);
        //var queryResult2 = _testIntSet.First(num => num == 12); // Exception

        Console.WriteLine($"queryResult: {queryResult}");
        Console.WriteLine($"queryResult: {queryResult1}");
        //Console.WriteLine($"queryResult: {queryResult2}");
        
        // FirstOrDefault
        var queryResult3 = _testIntSet.FirstOrDefault(num => num == 4 || num == 6);
        var queryResult4 = _testIntSet.FirstOrDefault(num => num == 12);

        Console.WriteLine($"queryResult: {queryResult3}");
        Console.WriteLine($"queryResult: {queryResult4}");
        
        // 
        var queryResult5 = _testIntSet.Single(num => num == 4);
        //var queryResult6 = _testIntSet.Single(num => num == 4 || num == 6); // Exception
        
        var queryResult6 = _testIntSet.SingleOrDefault(num => num == 4 || num == 6); // Нет Exception
        
        Console.WriteLine($"queryResult: {queryResult5}");
        //Console.WriteLine($"queryResult: {queryResult6}");
    }
}
