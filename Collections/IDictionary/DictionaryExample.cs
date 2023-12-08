using Collections.Helper;

namespace Collections.IDictionary;

public class DictionaryExample
{
    public void Run()
    {
        // Создаем словарь с ключами и значениями типа string
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        // Добавляем элементы в словарь
        myDictionary.Add("apple", 10);
        myDictionary.Add("banana", 5);
        myDictionary.Add("cherry", 7);

        // Проверяем наличие ключа в словаре
        bool containsKey = myDictionary.ContainsKey("banana");
        Console.WriteLine($"ContainsKey(\"banana\"): {containsKey}");

        // Получаем значение по ключу
        int value;
        if (myDictionary.TryGetValue("apple", out value))
        {
            Console.WriteLine($"Value for key 'apple': {value}");
        }

        // Итерация по парам ключ-значение
        PrintHelper.PrintCollection(myDictionary);

        // Удаление элемента по ключу
        myDictionary.Remove("cherry");

        // Выводим элементы после удаления
        Console.WriteLine("Elements after removal:");
        PrintHelper.PrintCollection(myDictionary);

        // Очистка словаря
        myDictionary.Clear();

        // Выводим элементы после очистки
        Console.WriteLine("Elements after clearing:");
        PrintHelper.PrintCollection(myDictionary);
    }
}