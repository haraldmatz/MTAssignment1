
using System.Data.Common;
using Assignment1.Moq.Interfaces;

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
            throw new System.NotImplementedException();
        }
    }
}
