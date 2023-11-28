namespace ArraysHomeWork;

public class Task6
{
    /*
     * Создайте массив и заполните массив.
     * Выведите массив на экран в строку.
     * Замените каждый элемент с нечётным индексом на ноль.
     * Снова выведете массив на экран на отдельной строке.
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
        for (int i = 1; i < array.Length; i += 2)
        {
            array[i] = 0;
        }
        
        Console.WriteLine("Модифицированный массив: " + string.Join(" ", array));
    }
}