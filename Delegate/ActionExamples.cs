namespace Delegate;

public class ActionExamples
{
    // Делегат Action представляет некоторое действие, которое ничего не возвращает
    
    public void SimpleAction()
    {
        // Action без параметров и без возвращаемого значения
        Action simpleAction = () => Console.WriteLine("Hello, World!");
        simpleAction();  // Вызов делегата

        // Action с параметром
        Action<string> greetAction = (name) => Console.WriteLine($"Hello, {name}!");
        greetAction("John");  // Вызов делегата с аргументом
    }
    
    public void PerformOperation(int x, int y, Action<int, int> operation)
    {
        operation(x, y);
    }
    
    public async Task Run()
    {
        // Асинхронное выполнение с использованием Action
        asyncAction();

        Console.WriteLine("Main method continues executing other tasks...");
        Console.ReadLine();
    }

    private Action asyncAction = async () =>
    {
        Console.WriteLine("Async Action Start");
        await Task.Delay(2000);
        Console.WriteLine("Async Action End");
    };

}