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
        public void GetAllCustomers()
        {
            // Prepare
            customerManager.AddHarald();
            customerManager.AddHans();

            // act
            List<Customer> customersResultList = customerManager.GetAllCustomers();

            // Assert 
            Assert.IsNotNull(customersResultList);
            Assert.AreEqual(2, customersResultList.Count);
            Assert.AreEqual("Harald", customerManager.Customers[0].FirstName);
            Assert.AreEqual("hans.hansson@test.se", customerManager.Customers[1].Email);
        }


        [TestCase]
        public void GetHansAndHarald()
        {
            
            // act
            List<Customer> customersResultList = CustomerManager.GetHaraldAndHans();
            

            // Assert 
            Assert.IsNotNull(customersResultList);
            Assert.AreEqual(2, customersResultList.Count);
            Assert.AreEqual("Harald", customersResultList[0].FirstName);
            Assert.AreEqual("hans.hansson@test.se", customersResultList[1].Email);
        }

        [TestCase]
        public void TestAddHaraldAndHans()
        {
            // Act
            var customerList = CustomerManager.GetHaraldAndHans();

            // Assert 
            Assert.IsNotNull(customerList);

            Assert.AreEqual("Harald", customerList[0].FirstName);
            Assert.AreEqual("hans.hansson@test.se", customerList[1].Email);
        }

        [TestCase]
        public void LookUpHans()
        {
            // Prepare
            customerManager.AddHarald();
            customerManager.AddHans();

          // Act
            var customer = customerManager.Lookup("hans.hansson@test.se");

            // Assert 
           Assert.AreEqual("Hans", customer.FirstName);
         }

        [TestCase]
        public void UpdateHans()
        {
            // Prepare
            customerManager.AddHarald();
            customerManager.AddHans();
          
            var customerToUpdate = customerManager.Lookup("hans.hansson@test.se");
            customerToUpdate.LastName = "Eriksson";

            // Act
            customerManager.Update(customerToUpdate);

            // Assert 
            Assert.AreEqual("Eriksson", customerManager.Customers[1].LastName);

        }

        [TestCase]
        public void DeleteHarald()
        {
            // Prepare
            customerManager.AddHarald();
            customerManager.AddHans();

      
            // Act
            customerManager.Delete("harald.matz@evry.com");

            // Assert 
            var customerResult = customerManager.Lookup("harald.matz@evry.com");
            Assert.IsNull(customerResult);


        }

      







        
     

       


    }

    
}
