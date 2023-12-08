using Collections.Helper;

namespace Collections.ISet;

public class HashSetExample
{
    public void Run()
    {
        // Создание HashSet для строк
        HashSet<string> uniqueNames = new HashSet<string>();

        // Добавление элементов
        uniqueNames.Add("Alice");
        uniqueNames.Add("Bob");
        uniqueNames.Add("Alice"); // Этот элемент не добавится, так как "Alice" уже существует

        // Вывод элементов
        Console.WriteLine("Unique Names:");
        PrintHelper.PrintCollection(uniqueNames);
        
        // Проверка наличия элемента
        bool containsBob = uniqueNames.Contains("Bob");
        Console.WriteLine($"Contains 'Bob': {containsBob}");

        // Удаление элемента
        uniqueNames.Remove("Alice");

        // Вывод элементов после удаления
        Console.WriteLine("\nNames after removal:");
        PrintHelper.PrintCollection(uniqueNames);
    }
}