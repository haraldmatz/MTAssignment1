
using System;
using System.Text;

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
            sb.Append("4. List Customers\n\n");
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


        public static string HandleInput(string inputKey)
        {
            switch (inputKey.ToUpper())
            {
                case "1":
                   return AddCustomer();
                    break;


                default:
                    return "";
                    break;
            }
        }
    }
}
