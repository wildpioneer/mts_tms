using DB_Npgsql.Models;
using DB_Npgsql.Services;
using GUI.Databases;

namespace GUI.Tests.DataBaseTests;

public class DatabaseTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private CustomerService? _customerService;
    private DBConnector? _simpleDbConnector;
        
    [OneTimeSetUp]
    public void SetUpConnection()
    {
        _simpleDbConnector = new DBConnector();
        _customerService = new CustomerService(_simpleDbConnector.Connection);
    }

    [OneTimeTearDown]
    public void closeConnection()
    {
        _simpleDbConnector?.CloseConnection();
    }
    
    [Test]
    public void GetAllCustomersTest()
    {
        _logger.Info("GetAllCustomersTest started...");
        var customersList = _customerService?.GetAllCustomers();

        Assert.That(customersList.Count, Is.EqualTo(4));

        _logger.Info("GetAllCustomersTest completed...");
    }

    [Test]
    public void AddCustomerTest()
    {
        _logger.Info("AddCustomerTest started...");
        
        Assert.That(_customerService?.AddCustomer(new Customer
        {
            Firstname = "Alexandr",
            Lastname = "Trostyanko"
        }), Is.EqualTo(1));
        
        _logger.Info("AddCustomerTest completed...");
    }

    [Test]
    public void DeleteCustomerTest()
    {
        _logger.Info("AddCustomerTest started...");
        
        Assert.That(_customerService?.DeleteCustomer(new Customer
        {
            Firstname = "Alexandr",
            Lastname = "Trostyanko"
        }), Is.EqualTo(1));
        
        _logger.Info("AddCustomerTest completed...");
    }
}