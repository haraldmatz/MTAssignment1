using System.Collections.Generic;
using NUnit.Framework;

namespace Assignment1.Test
{
    [TestFixture]
    public class TestCustomers
    {
        private List<Customer>  customers;


        // Test info2
        [SetUp]
        public void PrepareValue()
        {
            var customers = new List<Customer>();

            Assert.IsNotNull(customers);
        }
        [TestCase]
        public void TestAddHaraldMatz()
        {
  
            // Act
            var customer = CustomerHelper.AddHarald();


          //  //Assert     
          //  Assert.AreEqual(customer.Email, "harald.matz@evry.com");
          //  Assert.AreEqual(customer.FirstName, "Harald");
          //  Assert.AreEqual(customer.LastName, "Matz");
          //  Assert.AreEqual(customer.Address, "Mjölnerbacken 34");
          //  Assert.AreEqual(customer.City, "Sundbyberg");
          //  Assert.AreEqual(customer.Zip, "174 48");
          ////  Assert.AreEqual(customer.Telephone, "+46 76 643 41 20");
          //  Assert.AreEqual(customer.Email, "harald.matz@evry.com");
        }
        
 }
}
