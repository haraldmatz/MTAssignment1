using Assignment1.Util.Helpers;
using CustomerHandler.Classes;
using CustomerHandler.Helpers;
using NUnit.Framework;


namespace Assignment1.Test
{
    [TestFixture]
    public class TestConsoleApplication
    {
        private CustomerManager customerManager;

        [SetUp]
        public void Setup()
        {
            customerManager = new CustomerManager();
        }


        [TestCase]
        public void TestMenu()
        {
            // Act 
            string menu = MenuHelper.GetMenu();

            // Assert
            Assert.AreEqual("1. Add Customer",menu.Substring(0,15));
        }

        [TestCase]
        public void TestInput_AddCustomer()
        {
            // Act 
            string reply = MenuHelper.HandleInput("1", customerManager);

            // Assert
            Assert.AreEqual("Add Customer - Not implemented yet", reply.Substring(0, 34));
        }

        [TestCase]
        public void TestInput_UpdateCustomer()
        {
            // Act 
            string reply = MenuHelper.HandleInput("2",  customerManager);

            // Assert
            Assert.AreEqual("Update Customer - Not implemented yet", reply.Substring(0, 37));
        }

       

       [TestCase]
        public void TestInput_DeleteCustomer()
        {
            // Act 
            string reply = MenuHelper.HandleInput("3", customerManager);

            // Assert
            Assert.AreEqual("Delete Customer - Not implemented yet", reply.Substring(0, 37));
        }

        [TestCase]
        public void TestInput_ListCustomers()
        {
            // Prepare
            CustomerManager.Customers.Clear();
            CustomerManager.Customers.Add(CustomerHelper.GetHarald());
            CustomerManager.Customers.Add(CustomerHelper.GetHans());

            // Act 
            string reply = MenuHelper.HandleInput("4", customerManager );
            
            // Assert
            Assert.AreEqual("1. Harald", reply.Substring(0,9));
        }

        [TestCase]
        public void TestInput_AddOtherIpunt()
        {
            // Act 
            string reply = MenuHelper.HandleInput("XYZ", customerManager);

            // Assert
            Assert.AreEqual("1. Add Customer", reply.Substring(0, 15));
        }
    }
}
