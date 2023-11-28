namespace ArraysHomeWork;

public class Task12
{
    /*
     * Создайте двумерный массив целых чисел. Отсортируйте элементы в строках двумерного массива по возрастанию.
     */

    public void Execute()
    {
        // Получение размерности массива
        int arrayColumnSize = -1;
        int arrayRowsSize = -1;

        do
        {
            Console.Write("Введите размерность массива через ,: ");
            string input = Console.ReadLine();

            arrayColumnSize = Convert.ToInt32(input.Split(",")[0].Trim());
            arrayRowsSize = Convert.ToInt32(input.Split(",")[1].Trim());
        } while (arrayColumnSize <= 0 || arrayRowsSize <= 0);

        // Инициализация и заполнение массива
        int[,] array = new int[arrayRowsSize, arrayColumnSize];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(10);
                Console.Write($"{array[i, j]} ");
            }

            Console.WriteLine();
        }

        // Решение
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int[] tmpArray = new int[array.GetLength(1)];
            for (int j = 0; j < array.GetLength(1); j++)
            {
                tmpArray[j] = array[i, j];
            }

            Array.Sort(tmpArray);

            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = tmpArray[j];
            }
        }

        Console.WriteLine("Отсортированный массив.");

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}