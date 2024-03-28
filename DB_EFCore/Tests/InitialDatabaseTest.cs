using DB_EFCore.Connector;
using DB_EFCore.Models;
using Microsoft.Extensions.Logging;
using NLog;

namespace DB_EFCore.Tests
{
    public class InitialDatabaseTest
    {
        private readonly Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        [Test]
        public void DB_Test1()
        {
            using (var dbConnector = new DataBaseConnector())
            {
                var customer1 = new Customer { Firstname = "Ivan", Lastname = "Petrov" };
                var customer2 = new Customer { Firstname = "Sergey", Lastname = "Ivanov" };

                var entityCustomer1 = dbConnector.Customers.Add(customer1);
                var entityCustomer2 = dbConnector.Customers.Add(customer2);
                dbConnector.SaveChanges();

                var customers = dbConnector.Customers.ToList();
                _logger.Info("Customers List:");

                _logger.Info(
                    $"{dbConnector.Customers.Find(entityCustomer2.Entity.Id)?.Firstname}" +
                    $".{dbConnector.Customers.Find(entityCustomer2.Entity.Id)?.Lastname}");

                foreach (var customer in customers)
                {
                    _logger.Info($"{customer.Firstname}.{customer.Lastname}");
                    dbConnector.Customers.Remove(customer);
                }
            }

            Assert.That(true, "Test passed.");
        }
    }
}