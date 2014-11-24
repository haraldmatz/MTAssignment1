
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
      
        [SetUp]
        public void SetUp()
        {
            customerManager = new CustomerManager();
        }

        [TestCase]
        public void GetAllCustomers()
        {
            //Prepare - Fill the customer list
            customerManager = new CustomerManager();
            customerManager.AddHarald();
            customerManager.AddHans();
            
            // Create Mock object
            var mockSetCustomerRepository = new Mock<ICustomerRepository>();
            mockSetCustomerRepository.Setup(mr => mr.GetAllCusomers()).Returns(customerManager.Customers);
            var mockCustomerRepository = mockSetCustomerRepository.Object;

            // Act
            var allCustomers = mockCustomerRepository.GetAllCusomers();   

            // Assert
            mockSetCustomerRepository.Verify(h => h.GetAllCusomers(), Times.Exactly(1));
            Assert.AreEqual(allCustomers, customerManager.Customers);
        }

        [TestCase]
        public void TestAddHaraldToCustomers()
        {
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
        public void LookUpHans()
        {
            //// Prepare
            var mockSetCustomerRepository = new Mock<ICustomerRepository>();
            var customerTLookup = CustomerHelper.GetHans();
            mockSetCustomerRepository.Setup(c => c.LookUp(customerTLookup.Email));
            var mockCustomerRepository = mockSetCustomerRepository.Object;

            // Act
            mockCustomerRepository.LookUp(customerTLookup.Email);

            // Assert
            mockSetCustomerRepository.Verify(h => h.LookUp(customerTLookup.Email), Times.Exactly(1));
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
