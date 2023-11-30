namespace StringsHomeWork;

public class Task6
{
    /*
     * Дана строка (максимально 100 символов), содержащая слова, разделенные одним или несколькими пробелами, или знаками табуляции.
     * Заменить все знаки табуляции знаком пробела, удалить двойные пробелы из строки.
     * При реализации программы функции из библиотеки System.String не использовать.
     */

    // Простое решение 
    public void Execute()
    {
        string initialText = "Дана   строка  (максимально  100  символов), содержащая слова, разделенные одним или " +
                             "несколькими     пробелами,    или   знаками табуляции.";
        Console.WriteLine($"Исходная строка: {initialText}");

        string result;
        
        // Замена знаков табуляции пробелами
        char[] chars = new char[initialText.Length];
        
        for (int i = 0; i < initialText.Length; i++)
        {
            // Замена табуляции пробелами
            if (initialText[i] == '\t')
                chars[i] = ' ';
            else
                chars[i] = initialText[i];
        }

        result = new string(chars);
        
        // Удаление двойных пробелов
        chars = new char[result.Length];
        bool previousIsSpace = false;

        for (int i = 0; i < result.Length; i++)
        {
            // Удаление двойных пробелов
            if (result[i] == ' ')
            {
                if (!previousIsSpace)
                {
                    chars[i] = ' ';
                    previousIsSpace = true;
                }
            }
            else
            {
                chars[i] = result[i];
                previousIsSpace = false;
            }
        }
        
        result = new string(chars);
        Console.WriteLine($"Модифицированная строка: {result}");
    }
}