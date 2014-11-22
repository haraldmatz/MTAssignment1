using System.Collections.Generic;
using CustomerHandler.Classes;
using CustomerHandler.Helpers;
using NUnit.Framework;

namespace Assignment1.Test
{
    [TestFixture]
    public class TestCustomers
    {

        private CustomerManager customerManager;

        // Test info5
        [SetUp]
        public void SetUp()
        {
            customerManager = new CustomerManager();
        }


        [TestCase]
        public void TestAddHansHansson()
        {
           // Act
            customerManager.AddHarald();
            customerManager.AddHans();

            // Assert 
            Assert.IsNotNull(customerManager);
           
            Assert.AreEqual("Harald", customerManager.Customers[0].FirstName);
            Assert.AreEqual("hans.hansson@test.se", customerManager.Customers[1].Email);
        }
        
 }

    
}
