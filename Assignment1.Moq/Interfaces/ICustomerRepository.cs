using System.Collections.Generic;

using CustomerHandler.Classes;

namespace Assignment1.Moq.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCusomers();

        void AddCustomer(Customer customer);

    }
}