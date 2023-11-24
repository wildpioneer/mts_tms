// See https://aka.ms/new-console-template for more information


class Program
{
    public delegate void Handler(string alpha, string beta);

    public static event Handler Stuck;
    //public static Handler Stuck;

    static void Main1()
    {
        Stuck += ShowMessage;

        Stuck("Alex", "Trostyanko");
    }
    
    private static void ShowMessage(string firstname, string lastname) => Console.WriteLine($"{firstname} {lastname} Have fun!");
}
 