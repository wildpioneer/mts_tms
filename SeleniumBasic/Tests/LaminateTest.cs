using OpenQA.Selenium;

namespace NUnitTest.Tests;

public class LaminateTest : BaseTest
{
    [Test]
    public void CalcLaminateTest()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");

        IWebElement roomLength = Driver.FindElement(By.Id("ln_room_id"));
        roomLength.Clear();
        roomLength.SendKeys("100");
        IWebElement roomWidth = Driver.FindElement(By.Id("wd_room_id"));
        roomWidth.Clear();
        roomWidth.SendKeys("200");
        
        Driver.FindElement(By.Id("btn_calculate")).Click();
        
        Thread.Sleep(2000);
        
        Assert.That(Driver.FindElement(By.CssSelector(".calc-result")).Text, 
            Is.EqualTo("Требуемое количество плашек ламината: 10\nКоличество упаковок ламината: 1\nСтоимость ламината: NaN руб\nВес ламината: 0 кг"));
    }
    
}