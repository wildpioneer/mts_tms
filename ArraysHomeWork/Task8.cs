using Bogus;

namespace ArraysHomeWork;

public class Task8
{
    /*
     * Реализуйте алгоритм сортировки пузырьком.       
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
        int[] array = new int[arraySize];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(10);
        }

        Console.WriteLine("Массив: " + string.Join(" ", array));
        
        // Решение задачи
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                // Сравниваем соседние элементы
                if (array[j] > array[j + 1])
                {
                    // Меняем местами, если они находятся в неправильном порядке
                    // Простой вариант
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    // Продвинутый вариант
                    // (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
        
        Console.WriteLine("Отсортированный массив: " + string.Join(" ", array));
    }
}