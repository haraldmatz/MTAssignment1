using System.Collections.Generic;
using System.Linq;
using Assignment1.Moq.Classes;
using Assignment1.Moq.Interfaces;
using CustomerHandler.Classes;
using CustomerHandler.Helpers;
using Moq;
using NUnit.Framework;


namespace Assignment1.Test
{
    [TestFixture]
    public class TestCustomersMoq
    {
        private CustomerManager customerManager;
        ICustomerRepository mockSetCustomerRepository;

        [SetUp]
        public void SetUp()
        {
            
        }

        [TestCase]
        public void GetAllCustomers()
        {
            // Get Customer list
            customerManager = new CustomerManager();
            customerManager.AddHarald();
            customerManager.AddHans();


            // Mock the Products Repository using Moq
            var mockSetCustomerRepository = new Mock<ICustomerRepository>();

            // Return all the customers
            mockSetCustomerRepository.Setup(mr => mr.GetAllCusomers()).Returns(customerManager.Customers);
            var mockCustomerRepository = mockSetCustomerRepository.Object;
            // Mock the Products Repository using Moq


            var allCustomers = mockCustomerRepository.GetAllCusomers();   

           Assert.AreEqual(allCustomers, customerManager.Customers);
        }


        [TestCase]
        public void TestAddHaraldToCustomers()
        {
            var customerToAdd = CustomerHelper.AddHarald();

            // Get Customer list
            customerManager = new CustomerManager();
            customerManager.AddHarald();
            customerManager.AddHans();


            // Mock the Products Repository using Moq
            var mockSetCustomerRepository = new Mock<ICustomerRepository>();

            // Return all the customers
            mockSetCustomerRepository.Setup(mr => mr.GetAllCusomers()).Returns(customerManager.Customers);
           var  mockCustomerRepository = mockSetCustomerRepository.Object;
            // Mock the Products Repository using Moq


            var allCustomers = mockCustomerRepository.GetAllCusomers();

            Assert.AreEqual(allCustomers, customerManager.Customers);
            mockSetCustomerRepository.Verify(h => h.AddCustomer(customerToAdd), Times.Exactly(1));

        }


       






        
     

       


    }

    
}
