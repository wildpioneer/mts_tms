namespace ArraysHomeWork;

public class Task2
{
    /*
     * Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
     * Пусть число задается с консоли. Если такого числа нет - выведите сообщения об этом.
     * В результате должен быть новый массив без указанного числа.       
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
        int numberToDelete = Convert.ToInt32(Console.ReadLine());
        
        // Решение задачи
        int count = 0;
        
        foreach (int item in array)
        {
            if (item == numberToDelete) count++;
        }
        
        int[] newArray = new int[array.Length - count];
        int newIndex = 0;
        
        foreach (var item in array)
        {
            if (item != numberToDelete)
            {
                newArray[newIndex] = item;
                newIndex++;
            }
        }

        if (count > 0)
        {
            Console.WriteLine($"Число {numberToDelete} удалено из массива {count} раз(а).");
            Console.WriteLine("Новый массив:");
            
            foreach (var num in newArray)
            {
                Console.Write(num + " ");
            }
        }
        else
        {
            Console.WriteLine($"Число {numberToDelete} не найдено в массиве.");
        }
    }
}