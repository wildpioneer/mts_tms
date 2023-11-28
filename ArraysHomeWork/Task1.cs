namespace ArraysHomeWork;

public class Task1
{
    /*
     * Создайте массив целых чисел.
     * Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.
     * Пусть число для поиска задается с консоли.
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
        
        // Получение числа для проверки вхождения
        int numberToCheck = Convert.ToInt32(Console.ReadLine());
        
        // Решение задачи - простой вариант
        bool flag = false;
        foreach (var item in array)
        {
            if (item == numberToCheck)
            {
                Console.WriteLine("Введенное число входит в массив.");
                flag = true;
                break;
            }
        }
        
        if (!flag) Console.WriteLine("Введенное число невходит в массив."); 

        // Решение задачи - продвинутый вариант
        Console.WriteLine(array.Contains(numberToCheck)
            ? "Введенное число входит в массив."
            : "Введенное число невходит в массив.");
    }
}