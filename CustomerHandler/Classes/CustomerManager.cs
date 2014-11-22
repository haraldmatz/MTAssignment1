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
    }
}
