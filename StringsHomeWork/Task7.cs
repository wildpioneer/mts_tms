namespace StringsHomeWork;

public class Task7
{
    /*
     * Дана строка (максимальная длина 100 символов), содержащая слова, разделенные пробелами или знаками табуляции.
     * Число слов в строке не превышает 20, а длина каждого слова не более 10 символов.
     * Упорядочить слова в строке по алфавиту.       
     */

    // Простое решение 
    public void Execute()
    {
        string initialText = "Дана   строка   максимально  тест  символов  содержащая слова, разделенные одним или " +
                             "несколькими     пробелами   или   знаками табуляции.";
        Console.WriteLine($"Исходная строка: {initialText}");
        
        char[] delimiters = { ',', '.', ' ', '\t' };
        string[] words = initialText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);;

        Array.Sort(words, StringComparer.CurrentCultureIgnoreCase);

        string sortedString = string.Join(" ", words);
        
        Console.WriteLine($"Строка с упорядоченными словами по алфавиту: {sortedString}");
    }
}