using System;
using Assignment1.Util.Helpers;

namespace Assignment1.Cons
{
    class Program
    {
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
            HandleMenu( MenuHelper.HandleInput(Console.ReadKey()));
        }


    }
}
