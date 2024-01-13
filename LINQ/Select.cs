namespace LINQ;

public class Select
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        var r = _testObjectSet.List[2].Equals(_testObjectSet.List[3]);
        
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

        // Формирование нового типа данных
        IEnumerable<bool> queryResult12 =
            from number in _testIntSet
            select (number % 2 == 0);

        PrintHelper.Print(queryResult, i => Console.WriteLine($"Int: {i}"));
        PrintHelper.Print(queryResult11, i => Console.WriteLine($"String: {i}"));
        PrintHelper.Print(queryResult12, i => Console.WriteLine($"Bool: {i}"));

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
        
        PrintHelper.Print(methodResult, i => Console.WriteLine($"Int: {i}"));
        PrintHelper.Print(methodResult11, i => Console.WriteLine($"String: {i}"));
        PrintHelper.Print(methodResult12, i => Console.WriteLine($"Bool: {i}"));
        
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