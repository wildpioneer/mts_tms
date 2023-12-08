namespace Collections.IDictionary;

public class SortedListExample
{
    public void Run()
    {
        // Создаем отсортированный список для строк (ключи) и int (значения)
        SortedList<string, int> mySortedList = new SortedList<string, int>();

        // Добавляем элементы в отсортированный список
        mySortedList.Add("Apple", 10);
        mySortedList.Add("Cherry", 7);
        mySortedList.Add("Banana", 5);

        // Выводим элементы отсортированного списка
        Console.WriteLine("SortedList elements:");

        foreach (var pair in mySortedList)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }

        // Проверяем наличие ключа в отсортированном списке
        bool containsKey = mySortedList.ContainsKey("Banana");
        Console.WriteLine($"ContainsKey(\"Banana\"): {containsKey}");

        // Получаем значение по ключу
        int value;
        if (mySortedList.TryGetValue("Apple", out value))
        {
            Console.WriteLine($"Value for key 'Apple': {value}");
        }

        // Удаляем элемент по ключу
        mySortedList.Remove("Cherry");

        // Выводим элементы после удаления
        Console.WriteLine("SortedList elements after removal:");

        foreach (var pair in mySortedList)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }
}