namespace Generics;

public class MessengerService<S, R, M> 
    
    where M : Message
    where S : SimplePerson
    where R : SimplePerson
{
    public void SendMessage(S sender, R receiver, M message)
    {
        Console.WriteLine($"Отправитель: {sender.Name}");
        Console.WriteLine($"Получатель: {receiver.Name}");
        Console.WriteLine($"Сообщение: {message.Text}");
    }
}