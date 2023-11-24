namespace Delegate;

public class Program7
{
    delegate void Message();
    delegate int Operation(int x, int y);
    
    static void Main7()
    {
        Message? msg = null;
        //msg(); // ! Ошибка: делегат равен null
        msg?.Invoke();

        Operation op = Add;
        int result1 = op.Invoke(1, 2);

        op -= Add;
        //int result2 = op.Invoke(2, 3); // ! Ошибка: делегат равен null
        int? result3 = op?.Invoke(2, 3);
    }
    
    private static void ShowMessage() => Console.WriteLine("Have fun!"); 
    private static int Add(int x, int y) => x + y;
}