// See https://aka.ms/new-console-template for more information


using Event;

class ClientDelegateProgram
{
    public delegate int CalculateDiscount(ClientType clientType);

    public CalculateDiscount CalculateDiscountForClient { get; set; }

    private void CalculateDiscounts(IEnumerable<Client> clients)
    {
        foreach (Client client in clients)
        {
            client.Discount = CalculateDiscountForClient(client.Type);
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
        
        CalculateDiscountForClient = CalculateDiscountMethod;
        CalculateDiscounts(clients);

        foreach (var item in clients)
        {
            Console.WriteLine($"Discount is: {item.Discount}");
        }
    }

    private int CalculateDiscountMethod(ClientType clienttype)
    {
        if (clienttype == ClientType.Corporate) return 10;
        
        return 20;
    }
}
 