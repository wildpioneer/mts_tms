namespace Generics;

public class MessengerNew<T> where T : new()
{
    private T message;

    public MessengerNew()
    {
        // Создаем новый экземпляр типа T с использованием конструктора без параметров
        message = new T();
    }

    public void SendMessage()
    {
        Console.WriteLine($"Sending message: {message.ToString()}");
    }
}