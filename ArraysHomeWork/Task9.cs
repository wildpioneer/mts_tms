namespace ArraysHomeWork;

public class Task9
{
    /*
     * Умножение двух матриц
     * Создайте два массива целых чисел размером 3х3 (две матрицы).
     * Напишите программу для умножения двух матриц.
     * Первый массив: {{1,0,0,0},{0,1,0,0},{0,0,0,0}}
     * Второй массив: {{1,2,3},{1,1,1},{0,0,0},{2,1,0}}
     * Ожидаемый результат: 1 2 3 1 1 1 0 0 0
     */

    public void Execute()
    {
        // Инициализация и заполнение массива
        int[,] matrix1 =
        {
            { 1, 0, 0, 0 },
            { 0, 1, 0, 0 },
            { 0, 0, 0, 0 }
        };

        int[,] matrix2 =
        {
            { 1, 2, 3 },
            { 1, 1, 1 },
            { 0, 0, 0 },
            { 2, 1, 0 }
        };


        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            throw new ArgumentException("Несовместимые размерности матриц для умножения.");
        }

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }

                result[i, j] = sum;
            }
        }

        Console.WriteLine("Результат умножения матриц: ");

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write($"{result[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}