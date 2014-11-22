using System.Collections.Generic;
using Assignment1.Moq.Classes;
using Assignment1.Moq.Interfaces;
using NUnit.Framework;
using Moq;

namespace Assignment1.Test
{
    [TestFixture]
    public class TestCustomers
    {

        
        [SetUp]
        public void SetUp()
        {
        
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

            customerHandler.Verify(h => h.AddCustomer(), Times.Exactly(1));

        }

       


    }

    
}
