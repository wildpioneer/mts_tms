namespace ArraysHomeWork;

public class Task11
{
    /*
     * Создайте двумерный массив. Выведите на консоль диагонали массива.       
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
        int lowIndex = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
        string firstDiagonal = String.Empty;
        string secondDiagonal = String.Empty;
        
        for (int i = 0; i < lowIndex; i++)
        {
            firstDiagonal = string.Concat(firstDiagonal, array[i, i] + " ");
            secondDiagonal = string.Concat(secondDiagonal, array[array.GetUpperBound(0) - i, i] + " ");
        }
        
        Console.WriteLine($"Первая диогональ: {firstDiagonal}");
        Console.WriteLine($"Вторая диогональ: {secondDiagonal}");
    }
}