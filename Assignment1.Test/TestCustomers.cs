using System.Collections.Generic;
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
            var customer = CustomerHelper.AddHarald();

            // Assert 
            Assert.IsNotNull(customer);

        }
        
 }
}
