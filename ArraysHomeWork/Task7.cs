using Bogus;

namespace ArraysHomeWork;

public class Task7
{
    /*
     * Создайте массив строк. Заполните его произвольными именами людей.
     * Отсортируйте массив.
     * Результат выведите на консоль.       
     */

    public void Execute()
    {
        // Получение размерности массива
        int arraySize = -1;
        do
        {
            Console.Write("Введите размерность массива: ");
            arraySize = Convert.ToInt32(Console.ReadLine());
        } while (arraySize <= 0);

        // Инициализация и заполнение массива
        string[] array = new String[arraySize];

        for (int i = 0; i < array.Length; i++)
        {
            // Можно просто генерировать любыми способами
            array[i] = new Faker().Person.FirstName;
        }

        Console.WriteLine("Массив: " + string.Join(" ", array));
        
        // Решение задачи
        Array.Sort(array);
        
        Console.WriteLine("Отсортированный массив: " + string.Join(" ", array));
    }
}