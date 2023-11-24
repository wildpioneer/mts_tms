namespace Delegate;

public class Program5
{
    // Тип делегата
    public delegate void NoParameters();

    static void Main5()
    {
        NoParameters noPrm = delegate
        {
            Console.WriteLine("Have fun!");
        };
        
        Test(noPrm);
    }

    private static void Test(NoParameters noParam)
    {
        noParam();
    }
}