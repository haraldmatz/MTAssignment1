using System.Collections.Generic;
using CustomerHandler.Classes;
using CustomerHandler.Helpers;
using NUnit.Framework;

namespace Assignment1.Test
{
    [TestFixture]
    public class TestCustomers
    {
       
        // Test info5
        [SetUp]
     
        [TestCase]
        public void TestAddHaraldMatz()
        {
  
            // Act
            var customer = CustomerManager.AddHarald();

            // Assert 
            Assert.IsNotNull(customer);

            Assert.AreEqual("harald.matz@evry.com",  customer.Email );

        }

        [TestCase]
        public void TestAddHansHansson()
        {

            // Act
            var customer = CustomerManager.AddHans();

            // Assert 
            Assert.IsNotNull(customer);

            Assert.AreEqual("hans.hansson@test.se", customer.Email);

        }
        
 }

    
}
