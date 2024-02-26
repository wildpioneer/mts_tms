using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NativeSingleton;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class WebDriverSingleton
{
    private static WebDriverSingleton _instance;
    private static IWebDriver driver;

    // Приватный конструктор чтобы предотвратить создание экземпляров за пределами класса
    private WebDriverSingleton()
    {
        // Инициализация драйвера здесь
        var chromeOptions = new ChromeOptions();
        //chromeOptions.AddArguments("--incognito");
        chromeOptions.AddArguments("--disable-gpu");
        chromeOptions.AddArguments("--disable-extensions");
        //chromeOptions.AddArguments("--headless");

        chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
        chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

        new DriverManager().SetUpDriver(new ChromeConfig());
        driver = new ChromeDriver(chromeOptions);
    }

    // Метод для получения единственного экземпляра класса
    public static WebDriverSingleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new WebDriverSingleton();
        }
        return _instance;
    }

    // Метод для получения экземпляра драйвера
    public IWebDriver GetDriver()
    {
        return driver;
    }

    // Метод для закрытия драйвера
    public void CloseDriver()
    {
        driver.Quit();
    }
}