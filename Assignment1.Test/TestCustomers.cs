using System.Collections.Generic;
using CustomerHandler.Classes;
using NUnit.Framework;


namespace Assignment1.Test
{
    [TestFixture]
    public class TestCustomers
    {
        private CustomerManager customerManager;
        
        [SetUp]
        public void SetUp()
        {
            customerManager = new CustomerManager();
        }


        [TestCase]
        public void TestAddHaraldAndHans()
        {
            // Act
            customerManager.AddHarald();
            customerManager.AddHans();

            // Assert 
            Assert.IsNotNull(customerManager);

            Assert.AreEqual("Harald", customerManager.Customers[0].FirstName);
            Assert.AreEqual("hans.hansson@test.se", customerManager.Customers[1].Email);
        }

        [TestCase]
        public void LookUpHans()
        {
            // Prepare
            customerManager.AddHarald();
            customerManager.AddHans();

            var customerToLookFor = new Customer();
            var customerListResult = new List<Customer>();

            // Act
           customerListResult = customerManager.Lookup(customerToLookFor);

            // Assert 
            Assert.AreEqual("Hans" ,customerListResult[0].FirstName);
         
        }




        
     

       


    }

    
}
