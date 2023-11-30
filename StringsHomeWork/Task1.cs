using System.Text.RegularExpressions;

namespace StringsHomeWork;

public class Task1
{
    /*
     * Заменить в строке все вхождения 'test' на 'testing'.
     * Удалить из текста все символы, являющиеся цифрами.
     */

    // Простое решение 
    public void Execute()
    {
        string initialText = "test Test test 123 ... Do1ne.";
        Console.WriteLine($"Исходная строка: {initialText}");

        string replaceResult = initialText.Replace("test", "testing");
        string result = String.Empty;

        foreach (char c in replaceResult)
        {
            result += Char.IsDigit(c) ? "" : c;
        }

        Console.WriteLine($"Преобразованная строка: {result}");
    }

    // Продвинутое решение 
    public void ExecuteWithFile()
    {
        // Имя файла
        string fileName = "Task1.txt";

        // Путь к папке сборки
        string assemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        // Создаем полный путь к файлу
        string filePath = Path.Combine(assemblyPath, "Data", fileName);

        // Проверяем, существует ли файл
        if (File.Exists(filePath))
        {
            // Читаем содержимое файла
            string content = File.ReadAllText(filePath);

            // Выводим содержимое файла
            Console.WriteLine("Содержимое файла:");
            Console.WriteLine(content);
            
            string result = content.Replace("test", "testing");
            result = Regex.Replace(result, @"\d+", "");
            Console.WriteLine($"Преобразованная строка: {result}");
        }
        else
        {
            Console.WriteLine("Файл не найден.");
        }
    }
}