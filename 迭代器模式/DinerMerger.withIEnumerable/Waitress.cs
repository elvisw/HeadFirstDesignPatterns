using System;
using System.Globalization;
using System.Collections.Generic;

namespace DinerMerger.WithIEnumerable
{
    public class Waitress
    {
        private readonly IEnumerable<MenuItem> _pancakeHouseMenu;
        private readonly IEnumerable<MenuItem> _dinerMenu;

        public Waitress(IEnumerable<MenuItem> pancakeHouseMenu, IEnumerable<MenuItem> dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(_pancakeHouseMenu);
            Console.WriteLine("\nLUNCH");
            PrintMenu(_dinerMenu);
        }

        public void PrintVegetarianMenu()
        {
            PrintVegetarianMenu(_pancakeHouseMenu);
            PrintVegetarianMenu(_dinerMenu);
        }

        private static void PrintMenu(IEnumerable<MenuItem> iterator)
        {
            foreach(var menuItem in iterator)
            {                
                Console.WriteLine($"{menuItem.Name}, {menuItem.Price.ToString(CultureInfo.InvariantCulture)} -- ");
                Console.WriteLine(menuItem.Description);
            }
        }

        private static void PrintVegetarianMenu(IEnumerable<MenuItem> iterator)
        {
            foreach (var menuItem in iterator)
            {  
                if (menuItem.IsVegetarian)
                {
                    Console.WriteLine($"{menuItem.Name} \t\t {menuItem.Price.ToString(CultureInfo.InvariantCulture)}");
                    Console.WriteLine("\t" + menuItem.Description);
                }
            }
        }

        private bool IsVegetarian(string name, IEnumerable<MenuItem> iterator)
        {
            foreach (var menuItem in iterator)
            {
                if (menuItem.Name == name && menuItem.IsVegetarian)
                {
                    return true;
                }
            }
            return false;
        }
    }
}