
using System;
using System.Runtime.Remoting.Messaging;
using System.Text;
using CustomerHandler.Classes;

namespace Assignment1.Util.Helpers
{
    public static class MenuHelper
    {
        public static string GetMenu()
        {
            var sb = new StringBuilder();
            sb.Append("1. Add Customer - Not implemented yet \n");
            sb.Append("2. Update Customer Last Name\n");
            sb.Append("3. Delete Customer\n");
            sb.Append("4. List Customers\n");
            sb.Append("X. Exit program\n\n");
            sb.Append("Choose figures 1 to 4.");

            return sb.ToString();
        }

        public static string AddCustomer()
        {
            var sb = new StringBuilder();
            sb.Append("Add Customer - Not implemented yet \n");
            sb.Append("Press any key\n");
            return sb.ToString();
        }

        public static string HandleInput(string key)
        {
            switch (key.ToUpper())
            {
                case "1":
                   return AddCustomer();
                    break;

                case "4":
                    return ListCustomers();
                    break;

                case "X":
                    Environment.Exit(0);
                    return "";
                    break;

                default:
                    return GetMenu();
                    break;
            }
        }

        public static string ListCustomers()
        {
            var sb = new StringBuilder();
            var customerManager = new CustomerManager();
            customerManager.AddHarald();
            customerManager.AddHans();

            foreach (var customer in customerManager.Customers)
            {
                sb.Append(customer.FirstName + " " + customer.LastName + "\n");    
            }
            
            sb.Append("\n\nPress any key\n");
            return sb.ToString();
        }
    }
}
