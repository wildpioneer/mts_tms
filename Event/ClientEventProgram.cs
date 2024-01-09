// See https://aka.ms/new-console-template for more information


using Event;

class ClientEventProgram
{
    public delegate void Notificate(string email);

    public event Notificate Notified;

    public void NotifyClients(IEnumerable<Client> clients)
    {
        // какой-то код бизнес логики - подготовки например сообщения
        Notified += new NotificationByEmail().EmailNotification;

        foreach (Client client in clients)
        {
            // Оповещение
            Notified(client.Email);
        }
    }
    
    public void Run()
    {
        var clients = new Client[2];
        
        Client client = new Client();
        client.Type = ClientType.Corporate;
        client.Email = "test@email.com";

        Client client1 = new Client();
        client1.Type = ClientType.Individual;
        client1.Email = "test1@email.com";
        
        clients[0] = client;
        clients[1] = client1;
        
        NotifyClients(clients);
    }
}
 