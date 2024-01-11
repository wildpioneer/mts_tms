namespace Delegate;

public class FuncExample
{
    // Делегат Func. Он возвращает результат действия и может принимать параметры

    public void Run()
    {
        int result1 = DoOperation(6, DoubleNumber); // 12
        Console.WriteLine(result1);
 
        int result2 = DoOperation(6, SquareNumber); // 36
        Console.WriteLine(result2);
    }
    
    int DoOperation(int n, Func<int, int> operation) => operation(n);
    int DoubleNumber(int n) => 2 * n;
    int SquareNumber(int n) => n * n;
}