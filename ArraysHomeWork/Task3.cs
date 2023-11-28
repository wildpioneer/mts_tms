namespace ArraysHomeWork;

public class Task3
{
    /*
     * Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
     * Для генерации случайного числа используйте метод Random().
     * Пусть будет возможность создавать массив произвольного размера.
     * Пусть размер массива вводится с консоли.       
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
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine();

        // Решение задачи
        Array.Sort(array);
        
        Console.WriteLine($"Минимальное значение: {array[0]}");
        Console.WriteLine($"Максимальное значение: {array[array.GetUpperBound(0)]}");

        if (array.Length % 2 != 0)
        {
            Console.WriteLine($"Среднее значение: {array[array.GetUpperBound(0) / 2]}");
        }
        else
        {
            Console.WriteLine($"Среднее значение 1: {array[array.GetUpperBound(0) / 2]}");
            Console.WriteLine($"Среднее значение 2: {array[(array.GetUpperBound(0) / 2) + 1]}");
        }
    }
}