using Bogus;

namespace ArraysHomeWork;

public class Task10
{
    /*
     * Реализуйте алгоритм сортировки пузырьком.       
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
        int sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(10);
                sum += array[i, j];
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("Сумма всех элементов массива: " + sum);
    }
}