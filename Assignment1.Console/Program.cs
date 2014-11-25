using System;
using System.Collections.Generic;
using Assignment1.Util.Helpers;
using CustomerHandler.Classes;
using CustomerHandler.Helpers;

namespace Assignment1.Cons
{
    public class Program
    {
        public static List<Customer> Customers;
        
        // Does not need testing because it is run always when manual testing.
        private static void Main(string[] args)
        {
            HandleMenu(MenuHelper.GetMenu());
        }

        // Does not need testing because it is run always when manual testing.
        public static void HandleMenu(string menu)
        {
            Console.Clear();
            Console.WriteLine(menu);
            HandleMenu( MenuHelper.HandleInput(Console.ReadKey().KeyChar.ToString()));
        }
    }
}
