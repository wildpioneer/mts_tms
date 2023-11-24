namespace LINQ;

public class BaseSyntax
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    // Основной LINQ ситаксис
    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
        
        IEnumerable<int> queryResult =
            from number in _testIntSet
            select number;

        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }

        IEnumerable<string> queryResult1 =
            from text in _testStringSet.List
            select text;

        foreach (var i in queryResult1)
        {
            Console.WriteLine($"String: {i}");
        }

        IEnumerable<Person> queryResult2 =
            from person in _testObjectSet
            select person;

        foreach (var i in queryResult2)
        {
            Console.WriteLine($"Person: {i.Name} {i.Age}");
        }
    }
    
    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        
        IEnumerable<int> methodResult = _testIntSet.Select(number => number);
        //IEnumerable<int> methodResult = testSet.Where(num => num > 5).Select(number => number);

        foreach (var i in methodResult)
        {
            Console.WriteLine($"Int: {i}");
        }

        IEnumerable<string> methodResult1 = _testStringSet.List.Select(text => text);

        foreach (var i in methodResult1)
        {
            Console.WriteLine($"String: {i}");
        }

        IEnumerable<Person> methodResult2 = _testObjectSet.Select(obj => obj);

        foreach (var i in methodResult2)
        {
            Console.WriteLine($"Person: {i.Name} {i.Age}");
        }
    }

    public void RunStringExtention()
    {
        // Метод расширения String
        string test = "test";
        Console.WriteLine($"Char: {test.GetChar(0)}");
    }
}