namespace Delegate;

public class Lambda
{
    delegate void Message();

    delegate void Operation(int x, int y);

    delegate int Operation1(int x, int y);
    
    delegate bool IsEqual(int x);

    public void Example1()
    {
        Message hello = () => Console.WriteLine("Hello");
        hello();
        hello();
        hello();
    }
    
    public void Example2()
    {
        // Параметры лямбды
        Operation sum = (x, y) => Console.WriteLine($"{x} + {y} = {x + y}");
        sum(1, 2);
        sum(22, 14);
    }

    public void Example3()
    {
        // Возвращение результата
        // 1
        var sum1 = (int x, int y) => x + y;
        int sumResult = sum1(4, 5);
        Console.WriteLine(sumResult);

        // 2
        Operation1 multiply = (x, y) => x * y;
        int multiplyResult = multiply(4, 5);
        Console.WriteLine(multiplyResult);

        // 3
        var subtract = (int x, int y) =>
        {
            if (x > y) return x - y;
            else return y - x;
        };
        int result1 = subtract(10, 6);
        Console.WriteLine(result1);

        int result2 = subtract(-10, 6);
        Console.WriteLine(result2);
    }

    public void Example4()
    {
        // Добавление и удаление действий в лямбда-выражении
        var hello1 = () => Console.WriteLine("MТС");

        var message = () => Console.Write("Hello ");
        message += () => Console.WriteLine("World"); // добавляем анонимное лямбда-выражение
        message += hello1; // добавляем лямбда-выражение из переменной hello
        message += Print; // добавляем метод

        message();
        Console.WriteLine("--------------"); // для разделения вывода

        message -= Print; // удаляем метод
        message -= hello1; // удаляем лямбда-выражение из переменной hello

        message?.Invoke(); // на случай, если в message больше нет действий

        void Print() => Console.WriteLine("Welcome to C#");
    }

    public void Example5()
    {
        // Лямбда-выражение как аргумент метода
        int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // найдем сумму чисел больше 5
        int sumResult1 = Sum(integers, x => x > 5);
        Console.WriteLine(sumResult1);

        // найдем сумму четных чисел
        int sumResult2 = Sum(integers, x => x % 2 == 0);
        Console.WriteLine(sumResult2);

        int Sum(int[] numbers, IsEqual func)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                if (func(i))
                    result += i;
            }

            return result;
        }
    }

    public void Example6()
    {
        // Лямбда-выражение как результат метода
        Operation1 operation = SelectOperation(OperationType.Add);
        Console.WriteLine(operation(10, 4));
 
        operation = SelectOperation(OperationType.Subtract);
        Console.WriteLine(operation(10, 4));
 
        operation = SelectOperation(OperationType.Multiply);
        Console.WriteLine(operation(10, 4));
 
        Operation1 SelectOperation(OperationType opType)
        {
            switch (opType)
            {
                case OperationType.Add: return (x, y) => x + y;
                case OperationType.Subtract: return (x, y) => x - y;
                default: return (x, y) => x * y;
            }
        }
    }
}