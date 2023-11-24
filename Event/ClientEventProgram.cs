// See https://aka.ms/new-console-template for more information


using Event;

class ClientEventProgram
{
    public delegate void Notificate(string email);

    public event Notificate Notified;

    public void NotifyClients(IEnumerable<Client> clients)
    {
        foreach (Client client in clients)
        {
            // какой-то код бизнес логики - подготовки например сообщения
            
            // Оповещение
            Notified(client.Email);
        }
    }
    
    static void Main()
    {
        
    }
}
 