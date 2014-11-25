using CustomerHandler.Classes;

namespace CustomerHandler.Helpers
{
    public static class CustomerHelper
    {
        
        public static Customer GetHarald()
        {
            var customer = new Customer();

            customer.FirstName = "Harald";
            customer.LastName = "Matz";
            customer.Address = "Mjölnerbacken 34";
            customer.City = "Sundbyberg";
            customer.Zip = "174 48";
            customer.Telephone = "+46 76 643 41 20";
            customer.Email = "harald.matz@evry.com";  

            return customer;
        }


        public static Customer GetHans()
        {
            var customer = new Customer();

            customer.FirstName = "Hans";
            customer.LastName = "Hansson";
            customer.Address = "Sturegatan 5";
            customer.City = "Solna";
            customer.Zip = "144 48";
            customer.Telephone = "+46 76 443 41 20";
            customer.Email = "hans.hansson@test.se";

            return customer;
        }

        
    }
}