using Collections.Helper;

namespace Collections.IList;

public class ListExample
{
    public void Run()
    {
        // Создаем список строк
        List<string> stringList = new List<string>();

        // Добавление элементов
        stringList.Add("Первый");
        stringList.Add("Второй");
        stringList.Add("Третий");

        // Вставка элемента по индексу
        stringList.Insert(1, "Новый Второй");

        // Вывод всех элементов
        Console.WriteLine("Элементы в списке:");
        PrintHelper.PrintCollection(stringList);

        // Получение элемента по индексу
        string elementAtIndex = stringList[2];
        Console.WriteLine($"Элемент по индексу 2: {elementAtIndex}");

        // Поиск элемента
        bool containsElement = stringList.Contains("Третий");
        Console.WriteLine($"Список содержит 'Третий': {containsElement}");

        // Сортировка элементов
        stringList.Sort();
        Console.WriteLine("Отсортированная коллекция:");
        PrintHelper.PrintCollection(stringList);

        // Бинарный поиск элемента
        // Перед использованием нужно отсортировать коллекцию
        var item = stringList.BinarySearch("Новый Второй");
        Console.WriteLine($"Бинарный поиск 'Новый Второй': {item}");

        // Поиск индекса элемента
        var index = stringList.IndexOf("Новый Второй");
        Console.WriteLine($"Поиск индекса 'Новый Второй': {index}");
        
        // Удаление элемента
        stringList.Remove("Второй");

        // Удаление элемента по индексу
        stringList.RemoveAt(0);

        // Вывод после удаления
        Console.WriteLine("Элементы после удаления:");
        PrintHelper.PrintCollection(stringList);

        // Reverse элементов
        stringList.Reverse();
        Console.WriteLine("Перевернутая коллекция:");
        PrintHelper.PrintCollection(stringList);

        // Очистка
        stringList.Clear();
        Console.WriteLine($"Количество элементов после очистки: {stringList.Count}");
        PrintHelper.PrintCollection(stringList);
    }
}