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
    
    
    static void Main2()
    {
        
    }
}
 