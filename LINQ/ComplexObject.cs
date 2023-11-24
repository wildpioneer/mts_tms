namespace LINQ;

public class ComplexObject
{
    private TestObjectSet _testObjectSet = new();

    private List<Person> _additionalList = new List<Person>()
    {
        new Person("Dmitry", 43),
        new Person("Lola", 24),
        new Person("Alex", 45),
    };

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        // Объединение последовательностей
        // Начать с метода
        var queryResult =
            (
                from obj in _testObjectSet
                select obj)
            .Union(
                from obj in _additionalList
                select obj);

        foreach (var i in queryResult)
        {
            Console.WriteLine($"{i}");
        }
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // Объединение последовательностей
        var queryResult = _testObjectSet.Union(_additionalList);

        foreach (var i in queryResult)
        {
            Console.WriteLine($"{i}");
        }
    }
}