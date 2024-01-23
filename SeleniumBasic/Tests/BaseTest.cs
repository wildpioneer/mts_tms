using NUnit.Framework;
using NUnitTest.Core;
using NUnitTest.Utilites.Configuration;
using OpenQA.Selenium;

namespace NUnitTest.Tests;

public class BaseTest
{
    protected IWebDriver Driver { get; set; }
    
    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver!;
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}