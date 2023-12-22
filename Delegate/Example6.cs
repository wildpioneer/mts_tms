namespace Delegate;

public class Example6
{
    public void Run()
    {
        CurrencyExchangeMonitor currencyExchangeMonitor = new CurrencyExchangeMonitor();
        currencyExchangeMonitor.PriceChangeHandler = ShowPrice;

        DataCorrection dataCorrection = new DataCorrection();
        currencyExchangeMonitor.PriceChangeHandler += dataCorrection.UpdateData;
        
        currencyExchangeMonitor.Start();
    }
    
    // Сигнатура должна соответствовать делегату public delegate void PriceChange(int currentPrice);
    public void ShowPrice(int price)
    {
        Console.WriteLine($"Текущая цена: {price}");
    }
}