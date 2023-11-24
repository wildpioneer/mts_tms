namespace Delegate;

public class Program6
{
    static void Main6()
    {
        CurrencyExchangeMonitor currencyExchangeMonitor = new CurrencyExchangeMonitor();
        currencyExchangeMonitor.PriceChangeHandler = ShowPrice;

        DataCorrection dataCorrection = new DataCorrection();
        currencyExchangeMonitor.PriceChangeHandler += dataCorrection.UpdateData;
        
        currencyExchangeMonitor.Start();
    }
    
    // Сигнатура должна соответствовать делегату public delegate void PriceChange(int currentPrice);
    public static void ShowPrice(int price)
    {
        Console.WriteLine($"Текущая цена: {price}");
    }
}