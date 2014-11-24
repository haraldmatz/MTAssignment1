
using System;
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
            customerManager = new CustomerManager();
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
            /// Mock the Products Repository using Moq
            var mockSetCustomerRepository = new Mock<ICustomerRepository>();

            var customerToAdd = CustomerHelper.GetHarald();
            mockSetCustomerRepository.Setup(c => c.AddCustomer(customerToAdd));

            // Return all the customers
            var mockCustomerRepository = mockSetCustomerRepository.Object;
            // Mock the Products Repository using Moq
            mockCustomerRepository.AddCustomer(customerToAdd);

            mockSetCustomerRepository.Verify(h => h.AddCustomer(customerToAdd), Times.Exactly(1));

        }

        [TestCase]
        public void DeleteHans()
        {
            //// Prepare
            var mockSetCustomerRepository = new Mock<ICustomerRepository>();
            var customerToDelete = CustomerHelper.GetHans();
            mockSetCustomerRepository.Setup(c => c.DeleteCustomer(customerToDelete));
            var mockCustomerRepository = mockSetCustomerRepository.Object;
       
            // Act
            mockCustomerRepository.DeleteCustomer(customerToDelete);

            // Assert
            mockSetCustomerRepository.Verify(h => h.DeleteCustomer(customerToDelete), Times.Exactly(1));
        }

       

    }
}
