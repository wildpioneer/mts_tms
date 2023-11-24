namespace LINQ;

public class Distinct
{
    List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        // Удаление дубликатов последовательностей
        var queryResult = (
                from number in numbers
                select number
            )
            .Distinct();

        Console.WriteLine("Результат Distinct:");
        foreach (var item in queryResult)
        {
            Console.WriteLine(item);
        }
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // Удаление дубликатов последовательностей
        var methodResult = numbers.Distinct();

        Console.WriteLine("Результат Distinct (Method Syntax):");
        foreach (var item in methodResult)
        {
            Console.WriteLine(item);
        }
    }
}