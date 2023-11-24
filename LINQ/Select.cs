namespace LINQ;

public class Select
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
        
        // Получение такого же типа данных
        IEnumerable<int> queryResult =
            from number in _testIntSet
            select number;

        // Получение трансформированного типа данных
        IEnumerable<string> queryResult11 =
            from number in _testIntSet
            select number.ToString();

        IEnumerable<bool> queryResult12 =
            from number in _testIntSet
            select (number % 2 == 0);

        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }
        foreach (var i in queryResult11)
        {
            Console.WriteLine($"String: {i}");
        }
        foreach (var i in queryResult12)
        {
            Console.WriteLine($"Bool: {i}");
        }

        var queryResult3 =
            from person in _testObjectSet
            select person.Name;

        foreach (var i in queryResult3)
        {
            Console.WriteLine($"Persons Name: {i}");
        }
        
        // Создание нового типа данных
        var queryResult4 =
            from person in _testObjectSet
            select new
            {
                person.Name,
                YearOfBirth = (DateTime.Now.Year - person.Age)
            };
        
        foreach (var i in queryResult4)
        {
            Console.WriteLine($"Person's: Name - {i.Name}, Year of birth: {i.YearOfBirth}");
        }
    }
    
    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        
        // Получение такого же типа данных
        IEnumerable<int> methodResult = _testIntSet.Select(number => number);
        
        // Получение трансформированного типа данных
        IEnumerable<string> methodResult11 = _testIntSet.Select(number => number.ToString());
        IEnumerable<bool> methodResult12 = _testIntSet.Select(number => (number % 2 == 0));
        
        foreach (var i in methodResult)
        {
            Console.WriteLine($"Int: {i}");
        }
        foreach (var i in methodResult11)
        {
            Console.WriteLine($"String: {i}");
        }
        foreach (var i in methodResult12)
        {
            Console.WriteLine($"Bool: {i}");
        }

        var methodResult2 = _testObjectSet.Select(obj => obj.Name);

        foreach (var i in methodResult2)
        {
            Console.WriteLine($"Person Name: {i}");
        }
        
        // Создание нового типа данных
        var queryResult4 =
            _testObjectSet.Select(person => new { person.Name, YearOfBirth = (DateTime.Now.Year - person.Age) });
        
        foreach (var i in queryResult4)
        {
            Console.WriteLine($"Person's: Name - {i.Name}, Year of birth: {i.YearOfBirth}");
        }

    }
}