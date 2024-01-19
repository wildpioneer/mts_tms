namespace LINQ;

public class GroupBy
{
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        // Group By
        var queryResult =
            from person in _testObjectSet
            group person by person.Age
            into result
            select new { Name = result.Key, Count = result.Count() };

        PrintHelper.Print(queryResult, s => Console.WriteLine(s));
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // Group By
        Console.WriteLine("Group By");

        var queryResult = _testObjectSet
            .GroupBy(person => person.Age)
            .Select(result => new { Name = result.Key, Count = result.Count() });
        PrintHelper.Print(queryResult, s => Console.WriteLine(s));
    }
}
