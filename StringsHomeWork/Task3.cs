namespace StringsHomeWork;

public class Task3
{
    /*
     * Дана строка: “teamwithsomeofexcersicesabcwanttomakeitbetter.”
     * Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную,
     * а также всё, что после них во вторую.
     * Результат вывести в консоль.
     */

    // Простое решение 
    public void Execute()
    {
        string initialText = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
        Console.WriteLine($"Исходная строка: {initialText}");

        var splitResult = initialText.Split("abc");
        string var1 = splitResult[0];
        string var2 = splitResult[1];

        Console.WriteLine($"Первая часть: {var1}");
        Console.WriteLine($"Вторая часть: {var2}");
    }
}