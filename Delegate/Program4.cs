namespace Delegate;

public class Program4
{
    // Тип делегата
    public delegate void NoParameters();

    static void Main4()
    {
        NoParameters noPrm = delegate
        {
            Console.WriteLine("Have fun!");
        };
        
        noPrm();
    }
}