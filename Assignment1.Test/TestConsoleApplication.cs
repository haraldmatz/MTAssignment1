using System.ComponentModel;
using Assignment1.Util.Helpers;
using CustomerHandler.Classes;
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
            string reply = MenuHelper.HandleInput("1");

            // Assert
            Assert.AreEqual("Add Customer - Not implemented yet", reply.Substring(0, 34));
        }

        
        [TestCase]
        public void TestInput_ListCustomers()
        {
            // Prepare
            customerManager.AddHarald();
            customerManager.AddHans();

            // Act 
            string reply = MenuHelper.HandleInput("2");

            // Assert
            Assert.AreEqual("Harald", reply.Substring(0,6));
        }

        [TestCase]
        public void TestInput_AddOtherIpunt()
        {
            // Act 
            string reply = MenuHelper.HandleInput("XYZ");

            // Assert
            Assert.AreEqual("", reply);
        }
    }
}
