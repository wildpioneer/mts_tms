namespace ArraysHomeWork;

public class Task5
{
    /*
     * Создайте массив из n случайных целых чисел и выведите его на экран.
     * Размер массива пусть задается с консоли и размер массива может быть больше 5 и меньше или равно 10.
     * Если n не удовлетворяет условию - выведите сообщение об этом.
     * Если пользователь ввёл не подходящее число, то программа должна просить пользователя повторить ввод.
     * Создайте второй массив только из чётных элементов первого массива, если они там есть, и вывести его на экран.
     */

    public void Execute()
    {
        // Получение размерности массива
        int arraySize = -1;
        bool flag;

        do
        {
            Console.Write("Введите размерность массива: ");
            arraySize = Convert.ToInt32(Console.ReadLine());

            if (arraySize <= 5 || arraySize > 10)
            {
                Console.WriteLine("Размерность массива не соответствует допустимой. Повторите ввод.");
                flag = true;
            }
            else
            {
                Console.WriteLine("Размерность массива соответствует допустимой.");
                flag = false;
            }
        } while (flag);


        // Инициализация и заполнение массива
        int[] array = new int[arraySize];
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(10);
            Console.Write($"{array[i]} ");

            counter = array[i] % 2 == 0 ? ++counter : counter;
        }

        Console.WriteLine();

        // Решение задачи
        if (counter > 0)
        {
            int[] newArray = new int[counter];
            int index = 0;

            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    newArray[index++] = item;
                    Console.Write($"{item} ");
                }
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("В исходном массиве нет четных чисел.");
        }
    }
}