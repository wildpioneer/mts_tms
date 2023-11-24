namespace LINQ;

public class Where
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        var queryResult =
            from number in _testIntSet
            where number % 2 == 0
            select number;

        var queryResult1 =
            from text in _testStringSet.List
            where text.StartsWith("A")
            select text;

        var queryResult2 =
            from obj in _testObjectSet
            where obj.Age > 25
            select obj;

        foreach (var i in queryResult)
        {
            Console.WriteLine($"{i}");
        }

        foreach (var i in queryResult1)
        {
            Console.WriteLine($"{i}");
        }

        foreach (var i in queryResult2)
        {
            Console.WriteLine($"{i}");
        }
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        var methodResult = _testIntSet.Where(num => num % 2 == 0).Select(number => number);
        //var methodResult = testSet.Where<int>(num => num % 2 == 0).Select(number => number);

        foreach (var i in methodResult)
        {
            Console.WriteLine($"{i}");
        }
        
        var queryResult1 = _testStringSet.List.Where(text => text.StartsWith("A"));

        var queryResult2 = _testObjectSet.Where(obj => obj.Age > 25);

        foreach (var i in queryResult1)
        {
            Console.WriteLine($"{i}");
        }

        foreach (var i in queryResult2)
        {
            Console.WriteLine($"{i}");
        }
    }
}