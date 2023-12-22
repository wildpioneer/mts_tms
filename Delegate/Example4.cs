namespace Delegate;

public class Example4
{
    // Тип делегата
    public delegate void NoParameters();

    public void Run()
    {
        NoParameters noPrm = delegate
        {
            Console.WriteLine("Have fun!");
        };
        
        noPrm();
    }
}