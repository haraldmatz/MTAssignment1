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
               if (customer.FirstName==customerToLookFor.FirstName)
                   resultCustomerList.Add(customer);
            }

            return resultCustomerList;
        }
    }
}
