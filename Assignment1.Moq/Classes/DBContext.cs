

using Assignment1.Moq.Interfaces;
using CustomerHandler.Classes;

namespace Assignment1.Moq.Classes
{
    public class DBContext
    {
        private ICustomerHandler _customerHandler;

        public DBContext(ICustomerHandler customerHandler)
        {
            _customerHandler = customerHandler;
        }

        public void Add(Customer customerToAdd)
        {
            _customerHandler.AddCustomer(customerToAdd);
        }
    }
}
