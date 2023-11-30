namespace StringsHomeWork;

public class Task4
{
    /*
     * Дана строка: “Плохой день.”
     * Необходимо с помощью метода substring удалить слово "плохой".
     * После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
     * Заменить последний "!" на "?"
     */

    // Простое решение 
    public void Execute()
    {
        string initialText = "Плохой день.";
        Console.WriteLine($"Исходная строка: {initialText}");

        var result = initialText.Substring("плохой".Length);
        result = result.Insert(0, "Хороший");
        result = result.Insert(result.IndexOf("."), "!!!!!!!!!");
        result = result.Remove(result.LastIndexOf("!"));
        result = result.Insert(result.Length, "?");

        Console.WriteLine($"Модифицированная строка: {result}");
    }
}