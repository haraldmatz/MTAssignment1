using Assignment1.Util.Helpers;
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

        [TestCase]
        public void TestInput_AddCustomer()
        {
            // Act 
            string reply = MenuHelper.HandleInput("1");

            // Assert
            Assert.AreEqual("Add Customer is not implemented", reply.Substring(0, 31));
        }
    }
}
