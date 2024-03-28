using System.Diagnostics;
using DB_Npgsql.Dao;
using DB_Npgsql.Models;
using GUI.Databases;

namespace GUI.Tests.DataBaseTests;

public class DaoDatabaseTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private CustomerDao? _customerDao;
    private DBConnector? _simpleDbConnector;

    [OneTimeSetUp]
    public void SetUpConnection()
    {
        _simpleDbConnector = new DBConnector();
        _customerDao = new CustomerDao(_simpleDbConnector.Connection);
    }

    [OneTimeTearDown]
    public void CloseConnection()
    {
        _simpleDbConnector?.CloseConnection();
    }

    [Test]
    public void GetAllCustomersTest()
    {
        _logger.Info("GetAllCustomersTest started...");
        var customersList = _customerDao?.GetAllCustomers();

        Assert.That(customersList, Has.Count.GreaterThan(2));

        _logger.Info("GetAllCustomersTest completed...");
    }

    [Test]
    public void AddCustomerTest()
    {
        _logger.Info("AddCustomerTest started...");


        Assert.That(_customerDao?.Add(new Customer
        {
            Firstname = "Alexandr",
            Lastname = "Trostyanko",
            Email = "test@test.com",
            Age = 43
        }), Is.EqualTo(1));

        _logger.Info("AddCustomerTest completed...");
    }

    [Test]
    public void DeleteCustomerTest()
    {
        _logger.Info("AddCustomerTest started...");

        Assert.That(_customerDao?.Delete(_customerDao?.GetAllCustomers()[0].Id), Is.EqualTo(1));

        _logger.Info("AddCustomerTest completed...");
    }
}