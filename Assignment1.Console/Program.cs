using System;
using Assignment1.Util.Helpers;
using CustomerHandler.Classes;


namespace Assignment1.Cons
{
    public class Program
    {
        private static CustomerManager customerManager;

        // Does not need testing because it is run always when manual testing.
        private static void Main(string[] args)
        {
            customerManager = new CustomerManager();
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
