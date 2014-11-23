using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Moq.Classes;
using CustomerHandler.Classes;

namespace Assignment1.Moq.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCusomers();

        Customer FindCustomerByEmail(string email);

        List<Customer> FindCustomerByFirstName(string firstName);

        bool SaveCustomer(Customer customer);

        int AddWith3(int a);

        int Returnera4(int b);
    }
}
