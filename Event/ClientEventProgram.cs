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
            Notified(client.Email + "   Congratulation!!!");
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
        
        Notified += new NotificationByEmail().EmailNotification;
        
        NotifyClients(clients);
    }
}
 