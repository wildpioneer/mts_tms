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
     * 5 Проверить содержит ли номер документа последовательность abc и вывети сообщение содержит или нет
     * (причем, abc и ABC считается одинаковой последовательностью).
     * 6 Проверить начинается ли номер документа с последовательности 555.
     * 7 Проверить заканчивается ли номер документа на последовательность 1a2b.
     * Все эти методы реализовать в отдельном классе в статических методах, которые на вход (входным параметром)
     * будут принимать вводимую на вход программы строку.
     */

    // Простое решение 
    public void Execute()
    {
        string initialText = "1234-AbC-5678-dCX-9r0g";
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
        
        result = string.Format("{0:###/###/#/#}", result.ToLower());
        Console.WriteLine($"одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре: {result}");
    }
}