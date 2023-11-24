namespace Delegate;

public class Program3
{
    // Тип делегата
    public delegate void NoParameters();

    static void Main3()
    {
        NoParameters noPrm = ShowMessage1;

        noPrm += ShowMessage2;
        
        noPrm.Invoke(); // Более унифицированный вызов методов делегата
    }

    private static void ShowMessage1() => Console.WriteLine("Have fun!");

    private static void ShowMessage2() => Console.WriteLine("See you!");
}