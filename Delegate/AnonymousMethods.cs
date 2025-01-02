namespace Delegate;

public class AnonymousMethods
{
    delegate void MessageHandler(string message);

    public void Run()
    {
        MessageHandler handler = delegate(string mes) { Console.WriteLine(mes); };
        handler("hello world!");

        MessageHandler handler1 = delegate { Console.WriteLine("Это анонимный метод без параметров"); };
        handler1("hello world!");

        ShowMessage("hello!",
            delegate(string mes)
            {
                Console.WriteLine(mes);
            }
        );
    }

    private void ShowMessage(string message, MessageHandler handler)
    {
        handler(message);
    }
}