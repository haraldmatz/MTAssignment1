
using System;
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

                case "3":
                    return ShowCustomersThatCanBeDeleted();
                    break;

                case "4":
                    return ListCustomers();
                    break;

                // This is just tested manually
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

    
            Customer customer;

            for (int row=1; row<=customerManager.Customers.Count; row++)
            {
                customer = customerManager.Customers[row - 1];
                sb.Append(row + ". " + customer.FirstName + " " + customer.LastName + "\n");    
            }
            
            sb.Append("\n\nPress any key\n");
            return sb.ToString();
        }


        public static string ShowCustomersThatCanBeDeleted()
        { 
            return ("Choose the number Delete Customer\n") + ListCustomers();
        }
    }
}
