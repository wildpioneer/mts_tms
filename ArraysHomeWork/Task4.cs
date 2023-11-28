namespace ArraysHomeWork;

public class Task4
{
    /*
     * Создайте 2 массива из 5 чисел.
     * Выведите массивы на консоль в двух отдельных строках.
     * Посчитайте среднее арифметическое элементов каждого массива и сообщите,
     * для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).
     */

    public void Execute()
    {
        // Получение размерности массива
        int arraySize = 5;

        // Инициализация и заполнение массива
        int[] firstArray = new int[arraySize];
        int[] secondArray = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            firstArray[i] = new Random().Next(10);
            secondArray[i] = new Random().Next(10);
        }

        Console.WriteLine("Первый массив: " + string.Join(" ", firstArray));
        Console.WriteLine("Второй массив: " + string.Join(" ", secondArray));

        // Решение задачи - простой
        int sumOfFirstArray = 0;
        int sumOfSecondArray = 0;
        int averageOfFirstArray = 0;
        int averageOfSecondArray = 0;

        for (int i = 0; i < arraySize; i++)
        {
            sumOfFirstArray += firstArray[i];
            sumOfSecondArray += secondArray[i];
        }

        averageOfFirstArray = sumOfFirstArray / arraySize;
        averageOfSecondArray = sumOfSecondArray / arraySize;

        if (averageOfFirstArray == averageOfSecondArray)
            Console.WriteLine($"Значения арифметических средних для двух массивов равны: {averageOfFirstArray}");
        else if (averageOfFirstArray > averageOfSecondArray)
            Console.WriteLine(
                $"Арифметическое среднее первого массива {averageOfFirstArray} больше значения второго массива {averageOfSecondArray}");
        else
            Console.WriteLine(
                $"Арифметическое среднее второго массива {averageOfSecondArray} больше значения первого массива {averageOfFirstArray}");

        // Решение задачи - продвинутый
        if (firstArray.Average() == secondArray.Average())
            Console.WriteLine($"Значения арифметических средних для двух массивов равны: {firstArray.Average()}");
        else if (firstArray.Average() == secondArray.Average())
            Console.WriteLine(
                $"Арифметическое среднее первого массива {firstArray.Average()} больше значения второго массива {secondArray.Average()}");
        else
            Console.WriteLine(
                $"Арифметическое среднее второго массива {secondArray.Average()} больше значения первого массива {firstArray.Average()}");
    }
}