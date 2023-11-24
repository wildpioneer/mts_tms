namespace LINQ;

public class DataAggregation
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
        
        // Формирование более общего набора данных из двух простых
        var queryResult =
            from hotel in _testObjectSet.List
            from person in hotel.Persons
            select person;
        
        foreach (var i in queryResult)
        {
            Console.WriteLine($"Person's: Name - {i.Name}, Age: {i.Age}");
        }
    }
    
    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        
        var queryResult = _testObjectSet.List.SelectMany(hotel => hotel.Persons);
        
        foreach (var i in queryResult)
        {
            Console.WriteLine($"Person's: Name - {i.Name}, Age: {i.Age}");
        }

    }
}