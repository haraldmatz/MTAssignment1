using System.Collections.Generic;
using CustomerHandler.Classes;
using NUnit.Framework;


namespace Assignment1.Test
{
    [TestFixture]
    public class TestConsoleApplication
    {

        [TestCase]
        public void TestMenu()
        {
            // Act 
            string menu = GetMenu();

            // Assert
            Assert.AreEqual("Add Customer",menu.Substring(0,12));

        }
    }
}
