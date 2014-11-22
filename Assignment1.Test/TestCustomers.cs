using System.Collections.Generic;
using Assignment1.Moq.Classes;
using NUnit.Framework;
using Moq;

namespace Assignment1.Test
{
    [TestFixture]
    public class TestCustomers
    {

        
        [SetUp]
        public void SetUp()
        {
        
        }


        [TestCase]
        public void TestAddHaraldToCustomerObject()
        {
            var customerToAdd = new Customer();

            Assert.AreEqual("Harald", customerToAdd.FirstName);


        }

       


    }

    
}
