﻿
using System;
using System.Collections.Generic;
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
            sb.Append("2. Update Customer - Not implemented yet\n");
            sb.Append("3. Delete Customer - Not implemented yet\n");
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

        public static string UpdateCustomer()
        {
            var sb = new StringBuilder();
            sb.Append("Update Customer - Not implemented yet \n");
            sb.Append("Press any key\n");
            return sb.ToString();
        }

        public static string DeleteCustomer()
        {
            var sb = new StringBuilder();
            sb.Append("Delete Customer - Not implemented yet \n");
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

                case "2":

                    return UpdateCustomer();
                
                    break;

                case "3":
                    return DeleteCustomer();

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
            Customer customer;

            for (int row=1; row<=CustomerManager.GetHaraldAndHans().Count; row++)
            {
                customer = CustomerManager.GetHaraldAndHans()[row - 1];
                sb.Append(row + ". " + customer.FirstName + " " + customer.LastName + "\n");    
            }
            
            sb.Append("\n\nPress any key\n");
            return sb.ToString();
        }
        
    
    }
}
