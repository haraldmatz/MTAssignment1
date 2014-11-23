using System.Collections.Generic;
using Assignment1.Moq.Classes;
using Assignment1.Moq.Interfaces;
using CustomerHandler.Classes;
using NUnit.Framework;
using Moq;


namespace Assignment1.Test
{
    [TestFixture]
    public class TestMoqCustomer
    {
        private CustomerManager customerManager;
        
        [SetUp]
        public void SetUp()
        {
            customerManager = new CustomerManager();
        }


        [TestCase]
        public void TestAddHaraldToCustomerObject()
        {
            var customerToAdd = new Customer();
            customerToAdd.FirstName = "Harald";
            Assert.AreEqual("Harald", customerToAdd.FirstName);

            var customerHandler = new Mock<ICustomerHandler>();
            var dbContext = new DBContext(customerHandler.Object);

            dbContext.Add(customerToAdd);

            customerHandler.Verify(h => h.AddCustomer(customerToAdd), Times.Exactly(1));

        }

    }

    
}
