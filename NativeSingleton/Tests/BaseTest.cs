namespace NativeSingleton.Tests;

public class BaseTest
{
    protected static WebDriverSingleton Instance = WebDriverSingleton.GetInstance();
    
    //[OneTimeSetUp]
    public static void Start()
    {
        Console.WriteLine("OneTimeSetUp");
        Instance.GetDriver().Navigate().GoToUrl("http://onliner.by");
    }

    //[OneTimeTearDown]
    public static void Finish()
    {
        Console.WriteLine("OneTimeTearDown");   
        Instance.CloseDriver();
    }
}