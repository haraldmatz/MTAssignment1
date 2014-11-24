using System.Collections.Generic;
using CustomerHandler.Helpers;

namespace CustomerHandler.Classes
{
    public class CustomerManager
    {

        public List<Customer> Customers { get; set; }

        public CustomerManager()
        {
            Customers = new List<Customer>();
        }

        public void AddHarald()
        {
            Customers.Add(CustomerHelper.GetHarald());
        }

        public void AddHans()
        {
            var customer = CustomerHelper.GetHans();
            Customers.Add(customer);
        }

        public Customer Lookup(string email)
        {
            foreach (var customer in Customers)
            {
                if (customer.Email == email)
                    return customer;      
            }
            
            return null;
        }

        /// <summary>
        /// Assumtion that Email is unique for customer
        /// </summary>
        /// <param name="customerToUpdate"></param>
        public void Update(Customer customerToUpdate)
        {
            for (int row = 0; row < Customers.Count; row++)
            {
                if (customerToUpdate.Email == Customers[row].Email)
                    Customers[row] = customerToUpdate;
            }
        }

        public void Delete(string email)
        {
            for (int row = 0; row < Customers.Count; row++)
            {
                if (email == Customers[row].Email)
                        Customers.RemoveAt(row);
            }
        }

        public List<Customer> GetAllCustomers()
        {
            return Customers;
        }
    }
}
