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
            Customers.Add(CustomerHelper.AddHarald());
        }

        public void AddHans()
        {
            var customer = CustomerHelper.AddHans();
            Customers.Add(customer);
        }

        public List<Customer> Lookup(Customer customerToLookFor)
        {
            var resultCustomerList = new List<Customer>();

            foreach (var customer in Customers)
            {
                if (customer.FirstName == customerToLookFor.FirstName)
                         resultCustomerList.Add(customer);
            }
            
            return resultCustomerList;
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
    }
}
