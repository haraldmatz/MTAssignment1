
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
            // Prepare
            var customerToAdd = CustomerHelper.GetHarald();

            // Create Mock object
            var mockSetCustomerRepository = new Mock<ICustomerRepository>();
            mockSetCustomerRepository.Setup(c => c.AddCustomer(customerToAdd));
            var mockCustomerRepository = mockSetCustomerRepository.Object;
           
            // Act
            mockCustomerRepository.AddCustomer(customerToAdd);
            
            // Assert
            mockSetCustomerRepository.Verify(h => h.AddCustomer(customerToAdd), Times.Exactly(1));
        }

        [TestCase]
        public void LookUpHans()
        {
            //// Prepare
            var mockSetCustomerRepository = new Mock<ICustomerRepository>();
            var customerToLookup = CustomerHelper.GetHans();
            mockSetCustomerRepository.Setup(c => c.LookUp(customerToLookup.Email)).Returns(customerToLookup);
            var mockCustomerRepository = mockSetCustomerRepository.Object;

            // Act
            mockCustomerRepository.LookUp(customerToLookup.Email);

            // Assert
            mockSetCustomerRepository.Verify(h => h.LookUp(customerToLookup.Email), Times.Exactly(1));
            Assert.AreEqual("Hans", customerToLookup.FirstName);
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
