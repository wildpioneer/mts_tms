using System.Text;
using System.Text.RegularExpressions;

namespace StringsHomeWork;

public class Task5
{
    /*
     * Написать программу со следующим функционалом:
     * На вход передать строку (будем считать, что это номер документа).
     * Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число, а y — это буква.
     * 1 Вывести на экран в одну строку два первых блока по 4 цифры.
     * 2 Вывести на экран номер документа, но блоки из трех букв заменить на *** (каждая буква заменятся на *).
     * 3 Вывести на экран только одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре.
     * 4 Вывести на экран буквы из номера документа в формате "Letters:yyy/yyy/y/y" в верхнем регистре
     * (реализовать с помощью класса StringBuilder).
     * 5 Проверить содержит ли номер документа последовательность abc и вывести сообщение содержит или нет
     * (причем, abc и ABC считается одинаковой последовательностью).
     * 6 Проверить начинается ли номер документа с последовательности 555.
     * 7 Проверить заканчивается ли номер документа на последовательность 1a2b.
     * Все эти методы реализовать в отдельном классе в статических методах, которые на вход (входным параметром)
     * будут принимать вводимую на вход программы строку.
     */

    // Простое решение 
    public void Execute()
    {
        string initialText = "5554-AbC-5678-dCX-9r0g";
        Console.WriteLine($"Исходная строка: {initialText}");

        // 1
        var pattern = @"(\d{4})";
        MatchCollection matches = Regex.Matches(initialText, pattern);
        
        Console.WriteLine($"Два первых блока по 4 цифры: {matches[0].Groups[0].Value} {matches[1].Groups[0].Value}");

        // 2
        pattern = @"([a-zA-Z]{3})";
        var result = Regex.Replace(initialText, pattern, "***");
        
        Console.WriteLine($"Номер документа, но блоки из трех букв заменить на ***: {result}");

        // 3
        pattern = @"([a-zA-Z])";
        matches = Regex.Matches(initialText, pattern);
        result = String.Empty;
        
        foreach (Match match in matches)
        {
            result += match.Value;
        }
        
        result = string.Format("{0}/{1}/{2}/{3}", 
            result.Substring(0, 3),
            result.Substring(3, 3),
            result.Substring(6, 1),
            result.Substring(7, 1))
            .ToLower();

        Console.WriteLine($"Одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре: {result}");
        
        // 4
        pattern = @"[a-zA-Z]";
        StringBuilder results = new StringBuilder();

        matches = Regex.Matches(initialText, pattern);

        foreach (Match match in matches)
            results.Append(match.Value.ToUpper());

        results.Insert(3, "/").Insert(7, "/").Insert(9, "/").Insert(0, "Letters:");

        Console.WriteLine($"Одни буквы из номера документа в формате 'Letters:yyy/yyy/y/y' в верхнем регистре: {results}");
        
        // 5
        Console.WriteLine(initialText.Contains("abc", StringComparison.OrdinalIgnoreCase)
            ? "Строка содержит последовательность abc без учета регистра."
            : "Строка не содержит последовательность abc без учета регистра.");

        // 6
        Console.WriteLine(initialText.StartsWith("555")
            ? "Строка начинается с последовательности '555'."
            : "Строка не начинается с последовательности '555'.");
        
        // 7
        Console.WriteLine(initialText.EndsWith("1a2b")
            ? "Строка заканчивается последовательностью '1a2b'."
            : "Строка не заканчивается последовательностью '1a2b'.");
    }
}