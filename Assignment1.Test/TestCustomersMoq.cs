using System.Collections.Generic;
using System.Linq;
using Assignment1.Moq.Interfaces;
using CustomerHandler.Classes;
using Moq;
using NUnit.Framework;


namespace Assignment1.Test
{
    [TestFixture]
    public class TestCustomersMoq
    {
        private CustomerManager customerManager;
        ICustomerRepository mockCustomerRepository;

        [SetUp]
        public void SetUp()
        {
            // Get Customer list
            customerManager = new CustomerManager();
            customerManager.AddHarald();
            customerManager.AddHans();

        
            // Mock the Products Repository using Moq
           var mockCustomerRepository = new Mock<ICustomerRepository>();

            // Return all the customers
            mockCustomerRepository.Setup(mr => mr.GetAllCusomers()).Returns(customerManager.Customers);
        
            // Mock the Products Repository using Moq
        }

        [TestCase]
        public List<Customer> GetAllCustomers()
        {
            var allCustomers = mockCustomerRepository.GetAllCusomers();

            return allCustomers;
        }







        
     

       


    }

    
}
