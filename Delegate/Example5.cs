namespace Delegate;

public class Example5
{
    // Тип делегата
    public delegate void NoParameters();

    delegate int Operation(int x, int y);

    public void Run()
    {
        NoParameters noPrm = delegate { Console.WriteLine("Have fun!"); };

        // Делегаты как параметры методов
        Test(noPrm);

        // Возвращение делегатов из метода
        Operation operation = SelectOperation(OperationType.Add);
        Console.WriteLine(operation(10, 4)); // 14

        operation = SelectOperation(OperationType.Subtract);
        Console.WriteLine(operation(10, 4)); // 6

        operation = SelectOperation(OperationType.Multiply);
        Console.WriteLine(operation(10, 4)); // 40
    }

    private void Test(NoParameters noParam)
    {
        noParam();
    }

    private int Add(int x, int y) => x + y;
    private int Subtract(int x, int y) => x - y;
    private int Multiply(int x, int y) => x * y;

    private Operation SelectOperation(OperationType opType)
    {
        switch (opType)
        {
            case OperationType.Add: return Add;
            case OperationType.Subtract: return Subtract;
            default: return Multiply;
        }
    }
}