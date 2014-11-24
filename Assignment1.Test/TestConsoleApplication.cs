using System.Collections.Generic;
using Assignment1.Util.Helpers;
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
            string menu = MenuHelper.GetMenu();

            // Assert
            Assert.AreEqual("1. Add Customer",menu.Substring(0,15));
        }
    }
}
