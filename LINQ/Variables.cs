namespace LINQ;

public class Variables
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
        
        // Создание временных переменных
        var queryResult =
            from person in _testObjectSet
            let yearOfBirth = (DateTime.Now.Year - person.Age)
            select new
            {
                person.Name, 
                YearOfBirth = yearOfBirth
            };
        
        foreach (var i in queryResult)
        {
            Console.WriteLine($"Person's: Name - {i.Name}, Year of birth: {i.YearOfBirth}");
        }
    }
    
    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        
        // Создание временных переменных
        /*
        var queryResult = _testObjectSet
            //.Let
            .Select(person => new { person, YearOfBirth = (DateTime.Now.Year - person.Age) })
            .Select(@t => new { @t.person.Name, @t.YearOfBirth });
            */

        var queryResult = _testObjectSet
            .Select(person => new { person.Name, YearOfBirth = (DateTime.Now.Year - person.Age) });
        
        
        foreach (var i in queryResult)
        {
            Console.WriteLine($"Person's: Name - {i.Name}, Year of birth: {i.YearOfBirth}");
        }

    }
}