// See https://aka.ms/new-console-template for more information

namespace Delegate;

class Program1
{
    public delegate string WithParameters(string name1, string name2);
    
    static void Main2()
    {
        WithParameters withParameters1 = new (ShowMessage);
        WithParameters withParameters2 = ShowMessage;

        string result1 = withParameters1("Boris", "Ivan");
        string result2 = withParameters2("Olga", "Natasha");
        
        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }

    private static string ShowMessage(string value1, string value2)
    {
        Console.WriteLine($"{value1}, {value2} Have fun!!!");

        return "successful";
    }
}