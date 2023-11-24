
namespace Delegate;

class Program
{
    // Тип делегата
    public delegate void NoParameters();
    
    static void Main()
    {
        // Экземпляр делегата
        NoParameters noParameters1 = new NoParameters(ShowMessage);
        NoParameters noParameters2 = new (ShowMessage);
        NoParameters noParameters3 = ShowMessage;

        noParameters1();
        noParameters2();
        noParameters3();
    }

    private static void ShowMessage()
    {
        Console.WriteLine("Have fun!!!");
    }
}